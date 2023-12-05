using OpenIddict.Abstractions;
using Serenity.Pro.OpenIddict;

namespace GXpert.Administration.Pages;
public class OpenIdAuthorizationController(
    IUserPasswordValidator userPasswordValidator,
    IUserRetrieveService userRetrieveService,
    IOptionsMonitor<OpenIdSettings> options = null,
    IOpenIddictApplicationManager applicationManager = null,
    IOpenIddictAuthorizationManager authorizationManager = null,
    ITextLocalizer textLocalizer = null) : OpenIdAuthorizationControllerBase(userRetrieveService, options, applicationManager, authorizationManager, textLocalizer)
{
    private readonly IUserPasswordValidator userPasswordValidator = userPasswordValidator ?? throw new ArgumentNullException(nameof(userPasswordValidator));

    protected override bool ValidatePassword(string username, string password)
    {
        return !string.IsNullOrEmpty(username) &&
               userPasswordValidator.Validate(ref username, password) == PasswordValidationResult.Valid;
    }
}
