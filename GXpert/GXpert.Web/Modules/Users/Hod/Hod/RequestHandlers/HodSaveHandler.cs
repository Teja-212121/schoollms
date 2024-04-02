using GXpert.Administration;
using Serenity.Services;
using System.IO;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Users.HodRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Users.HodRow;

namespace GXpert.Users;

public interface IHodSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class HodSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IHodSaveHandler
{
    public HodSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    string teacherUsername = "";
    string teacherPassword = "";
    protected override void BeforeSave()
    {
        base.BeforeSave();

        Row.IsActive = true;
        if (IsCreate)
        {

            var user = Connection.TryFirst<UserRow>(UserRow.Fields.Email == Row.Email || UserRow.Fields.Username == Row.Email);
            if (user != null)
                throw new ValidationError("User Already Exists");
            string salt = null;
            teacherPassword = Password.Generate(8, 4);
            var hash = UserSaveHandler.GenerateHash(teacherPassword, ref salt);
            var displayName = Row.Name.TrimToEmpty();
            var email = Row.Email;
            var username = Row.Email;
            teacherUsername = username;

            var userId = (int)Connection.InsertAndGetID(new UserRow
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
                LastDirectoryUpdate = DateTime.Now,
            });

            //Connection.Execute(string.Format(@"INSERT INTO dbo.UserPermissions (UserId, PermissionKey, Granted)
            //                                           VALUES ({0}, 'Administration:Student', 1)", userId));

            //Connection.Execute(string.Format(@"INSERT INTO dbo.UserRoles (UserId, RoleId)
            //                                           VALUES ({0}, 2)", userId));

            Row.UserId = userId;

            byte[] bytes;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                bw.Write(DateTime.UtcNow.AddHours(3).ToBinary());
                bw.Write(userId);
                bw.Flush();
                bytes = ms.ToArray();
            }
        }
    }
}