using Serenity.Web.Providers;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Administration.UserRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Administration.UserRow;

namespace GXpert.Administration;
public interface IUserSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class UserSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), IUserSaveHandler
{
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

    private string password;

    protected override void GetEditableFields(HashSet<Field> editable)
    {
        base.GetEditableFields(editable);

        if (!Permissions.HasPermission(PermissionKeys.Security))
        {
            editable.Remove(Fld.Source);
            editable.Remove(Fld.IsActive);
        }
    }

    public static string ValidateUsername(IDbConnection connection, string username, int? existingUserId,
        ITextLocalizer localizer)
    {
        username = username.TrimToNull();

        if (username == null)
            throw DataValidation.RequiredError(Fld.Username, localizer);

        if (!UserHelper.IsValidUsername(username))
            throw new ValidationError("InvalidUsername", "Username",
                "Usernames should start with letters, only contain letters and numbers!");

        var existing = UserHelper.GetUser(connection,
            new Criteria(Fld.Username) == username |
            new Criteria(Fld.Username) == username.Replace('I', 'İ'));

        if (existing != null && existingUserId != existing.UserId)
            throw new ValidationError("UniqueViolation", "Username",
                "A user with same name exists. Please choose another!");

        return username;
    }

    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (IsUpdate)
        {
            if (Row.Username != Old.Username)
                Row.Username = ValidateUsername(Connection, Row.Username, Old.UserId.Value, Localizer);

            if (Row.DisplayName != Old.DisplayName)
                Row.DisplayName = UserHelper.ValidateDisplayName(Row.DisplayName, Localizer);
        }

        if (IsCreate)
        {
            Row.Username = ValidateUsername(Connection, Row.Username, null, Localizer);
            Row.DisplayName = UserHelper.ValidateDisplayName(Row.DisplayName, Localizer);
        }

        if (IsCreate || (Row.IsAssigned(Fld.Password) && !string.IsNullOrEmpty(Row.Password)))
        {
            if (Row.IsAssigned(Fld.PasswordConfirm) && !string.IsNullOrEmpty(Row.PasswordConfirm) &&
                Row.Password != Row.PasswordConfirm)
                throw new ValidationError("PasswordConfirmMismatch", "PasswordConfirm", ExtensionsTexts.Validation.PasswordConfirmMismatch.ToString(Localizer));

            password = Row.Password = UserHelper.ValidatePassword(Row.Password, Localizer);
        }
    }

    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
        {
            Row.Source = "site";
            Row.IsActive = Row.IsActive ?? 1;
        }

        if (IsCreate || !string.IsNullOrEmpty(Row.Password))
        {
            string salt = null;
            Row.PasswordHash = UserHelper.GenerateHash(password, ref salt);
            Row.PasswordSalt = salt;
        }
    }

    protected override void AfterSave()
    {
        base.AfterSave();

        Cache.InvalidateOnCommit(UnitOfWork, Fld);
    }
    public static string CalculateHash(string password, string salt)
    {
        return SiteMembershipProvider.ComputeSHA512(password + salt);
    }
    public static string GenerateHash(string password, ref string salt)
    {
        salt = salt ?? Serenity.IO.TemporaryFileHelper.RandomFileCode().Substring(0, 5);
        return CalculateHash(password, salt);
    }
}