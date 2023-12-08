using GXpert.Administration;
using GXpert.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GXpert.Membership.Pages;
/*[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[JsonRequest, IgnoreAntiforgeryToken]*/
[Route("Account/[action]")]
public partial class AccountPage(ITwoLevelCache cache, ITextLocalizer localizer) : Controller
{
    protected ITwoLevelCache Cache { get; } = cache ?? throw new ArgumentNullException(nameof(cache));
    protected ITextLocalizer Localizer { get; } = localizer ?? throw new ArgumentNullException(nameof(localizer));

    [HttpGet]
    public ActionResult Login(int? denied, string activated, string returnUrl
    )
    {
        if (denied == 1)
            return View(MVC.Views.Errors.AccessDenied,
                ("~/Account/Login?returnUrl=" + Uri.EscapeDataString(returnUrl)));

        ViewData["Activated"] = activated;
        ViewData["HideLeftNavigation"] = true;
        var model = new LoginPageModel()
        {
        };
        return View(MVC.Views.Membership.Account.Login.LoginPage, model);
    }

    [HttpGet]
    public ActionResult AccessDenied(string returnURL)
    {
        ViewData["HideLeftNavigation"] = !User.IsLoggedIn();

        return View(MVC.Views.Errors.AccessDenied, (object)returnURL);
    }

    [HttpPost, JsonRequest]
    public Result<ServiceResponse> Login(LoginRequest request,
        [FromServices] IUserPasswordValidator passwordValidator,
        [FromServices] IUserRetrieveService userRetriever,
        [FromServices] IUserClaimCreator userClaimCreator,
        [FromServices] IEmailSender emailSender = null,
        [FromServices] ISMSService smsService = null)
    {

        return this.ExecuteMethod(() =>
        {
            ArgumentNullException.ThrowIfNull(request);
            ArgumentException.ThrowIfNullOrEmpty(request.Username);
            ArgumentNullException.ThrowIfNull(passwordValidator);
            ArgumentNullException.ThrowIfNull(userRetriever);
            ArgumentNullException.ThrowIfNull(userClaimCreator);

            var username = request.Username;
            var result = passwordValidator.Validate(ref username, request.Password);
            if (result == PasswordValidationResult.Valid)
            {
                CheckTwoFactorAuthentication(username, request, userRetriever, emailSender, smsService);

                var principal = userClaimCreator.CreatePrincipal(username, authType: "Password");
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).GetAwaiter().GetResult();
                return new ServiceResponse();
            }

            if (result == PasswordValidationResult.InactiveUser)
            {
                throw new ValidationError("InactivatedAccount", Texts.Validation.AuthenticationError.ToString(Localizer));
            }

            throw new ValidationError("AuthenticationError", Texts.Validation.AuthenticationError.ToString(Localizer));
        });
    }

    private ViewResult Error(string message)
    {
        return View(MVC.Views.Errors.ValidationError, new ValidationError(message));
    }

    public string KeepAlive()
    {
        return "OK";
    }

    public ActionResult Signout()
    {
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        HttpContext.RequestServices.GetService<IElevationHandler>()?.DeleteToken();
        return new RedirectResult("~/");
    }

    /*[AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> GenerateToken(LoginRequest request,
                        [FromServices] IUserPasswordValidator passwordValidator,
                        [FromServices] IUserRetrieveService userRetriever,
                        [FromServices] IEmailSender emailSender = null,
                        [FromServices] ISMSService smsService = null)
    {
        bool loggedIn = false;
        if (ModelState.IsValid)
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.Username))
                throw new ArgumentNullException(nameof(request.Username));

            if (passwordValidator is null)
                throw new ArgumentNullException(nameof(passwordValidator));

            if (userRetriever is null)
                throw new ArgumentNullException(nameof(userRetriever));

            await Task.Run(() =>
            {
                var username = request.Username;
                var result = passwordValidator.Validate(ref username, request.Password);
                if (result == PasswordValidationResult.Valid)
                {
                    loggedIn = true;
                }
            });
            if (loggedIn)
            {
                UserDefinition userDefinition = (UserDefinition)userRetriever.ByUsername(request.Username);
                var claims = new[]
                {
                        new Claim(JwtRegisteredClaimNames.NameId,userDefinition.Id),
                        new Claim(ClaimTypes.Name,request.Username),
                        new Claim(ClaimTypes.NameIdentifier,request.Username),
                        new Claim(JwtRegisteredClaimNames.UniqueName,request.Username),
                        new Claim(JwtRegisteredClaimNames.Sub, request.Username),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6LftZ6gUAAAAAD1Ken7Eep9Wv3Z_WISb9lrxh_QN"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken("https://omrapp.azurewebsites.net", "https://omrapp.azurewebsites.net",
                  claims,
                  expires: DateTime.Now.AddDays(365),
                  signingCredentials: creds);

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }
            else
            {
                return BadRequest(Texts.Validation.AuthenticationError);
            }
        }
        return BadRequest("Could not create token");
    }

    [AllowAnonymous, HttpPost]
    public Result<ServiceResponse> SignUpAsStudent(SignUpRequest request, [FromServices] IOptions<EnvironmentSettings> options = null)

    {
        return this.UseConnection("Default", connection =>
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrWhiteSpace(request.Email))
                throw new ArgumentNullException(nameof(request.Email));
            if (string.IsNullOrEmpty(request.Password))
                throw new ArgumentNullException(nameof(request.Password));

            UserHelper.ValidatePassword(request.Password, Localizer);
            if (string.IsNullOrWhiteSpace(request.DisplayName))
                throw new ArgumentNullException(nameof(request.DisplayName));

            if (connection.Exists<UserRow>(
                    UserRow.Fields.Username == request.Email |
                    UserRow.Fields.Email == request.Email))
            {
                throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
            }

            if (connection.Exists<StudentRow>(new Criteria(StudentRow.Fields.Name) == request.DisplayName))
            {
                throw new ValidationError("TeacherInUse", "Teacher Already Exists!");

            }
            if (connection.Exists<UserRow>(
                    UserRow.Fields.Username == request.Email |
                    UserRow.Fields.Email == request.Email))
            {
                throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse.ToString(Localizer));
            }
            using var uow = new UnitOfWork(connection);
            string salt = null;
            var hash = UserHelper.GenerateHash(request.Password, ref salt);
            var displayName = request.DisplayName.TrimToEmpty();
            var email = request.Email;
            var username = request.Email;

            var fld = UserRow.Fields;
            var userId = (int)connection.InsertAndGetID(new UserRow
            {
                Username = username,
                Source = "sign",
                DisplayName = displayName,
                Email = email,
                PasswordHash = hash,
                PasswordSalt = salt,
                IsActive = 1,
                InsertDate = DateTime.Now,
                InsertUserId = 1,
                LastDirectoryUpdate = DateTime.Now
            });


            connection.Execute(string.Format(@"INSERT INTO UserPermissions (UserId, PermissionKey, Granted)
                                                       VALUES ({0}, 'Administration:Teachers', 1)", userId));

            connection.Execute(string.Format(@"INSERT INTO UserRoles (UserId, RoleId)
                                               VALUES ({0}, 2)", userId));

            var mobile = request.Mobile.TrimToEmpty();
            var users = uow.Connection.TryFirst<UserRow>(UserRow.Fields.Username == request.Email);

            StudentRow studentRow = new StudentRow();
            studentRow.Name = request.DisplayName;
            studentRow.Mobile = mobile;
            studentRow.Email = request.Email;
            studentRow.UserId = userId;
            studentRow.IsActive = true;
            studentRow.InsertDate = DateTime.Now;
            studentRow.InsertUserId = Convert.ToInt32(User.GetIdentifier());
            long teachersId = (long)connection.InsertAndGetID(studentRow);

            byte[] bytes;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                bw.Write(DateTime.UtcNow.AddHours(3).ToBinary());
                bw.Write(userId);
                bw.Flush();
                bytes = ms.ToArray();
            }
            var token = Convert.ToBase64String(HttpContext.RequestServices
                               .GetDataProtector("Activate").Protect(bytes));

            var externalUrl = options?.Value?.SiteExternalUrl ??
                Request.GetBaseUri().ToString();

            var activateLink = UriHelper.Combine(externalUrl, "Account/Activate?t=");
            activateLink += Uri.EscapeDataString(token);
            var LoginLink = UriHelper.Combine(externalUrl, "Account/Login");
            var emailModel = new ActivateEmailModel
            {
                Username = username,
                DisplayName = displayName,
                ActivateLink = activateLink,
                LoginLink = LoginLink,
                Password = request.Password,

            };

            var emailSubject = "Student Registration Successful";
            var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,
                MVC.Views.Membership.Account.SignUp.StudentSignupEmail, emailModel);
            emailModel.ActivateLink = activateLink;

            emailModel.Username = username;
            emailModel.DisplayName = displayName;
            emailModel.Password = request.Password;
            *//*#region Email
            var mail = new MailRow();
            mail.Uid = Guid.NewGuid();
            mail.Subject = emailSubject;
            mail.Body = emailBody;
            mail.Priority = MailQueuePriority.High;
            mail.Status = MailStatus.InQueue;
            mail.LockExpiration = DateTime.Now.AddDays(-1);
            mail.InsertDate = DateTime.Now;
            mail.InsertUserId = Convert.ToInt32(User.GetIdentifier());
            mail.RetryCount = 0;
            var AwsuserId = "AKIAJRD5ISHDUSMDQY3A";
            var AwsPassword = "AiT6XWNew81FxpC2bFlG03qXtICsATCofb7buTYE1rwg";
            var FromEmail = "hello@antargyan.com";
            mail.MailFrom = FromEmail;
            mail.AwsUserId = AwsuserId;
            mail.AwsPassword = AwsPassword;
            mail.MailTo = email;
            connection.Insert<MailRow>(mail);
            #endregion*//*

            uow.Commit();

            return new ServiceResponse();
        });
    }*/
}