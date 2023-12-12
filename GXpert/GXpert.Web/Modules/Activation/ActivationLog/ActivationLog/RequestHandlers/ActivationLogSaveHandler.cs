using GXpert.Administration;
using GXpert.Playlist;
using GXpert.Users;
using GXpert.Web.Enums;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.ActivationLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.ActivationLogRow;

namespace GXpert.Activation;

public interface IActivationLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogSaveHandler
{
    public ActivationLogSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    Int32 ActvtnId;
    protected override void BeforeSave()
    {
        base.BeforeSave();

        var SerialKey = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);

        if (SerialKey == null)
        {
            Row.Note = "Serial Key does not exist";
        }
        else
        {
            Row.Code = Row.SerialKey;
            Row.PlayListId = SerialKey.PlayListId.Value;
            if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt16(EKeyStatus.ACTIVATED) && SerialKeyRow.Fields.SerialKey == Row.SerialKey))
            {
                Row.Note = "This  SerialKey is already Activated!!!";
            }
            else if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey && SerialKeyRow.Fields.EStatus == Convert.ToInt32(EKeyStatus.OPEN) && SerialKeyRow.Fields.PlayListId == SerialKey.PlayListId.Value))
            {
                Row.Note = "This Serial key and Examlist Mismatched";
            }
            else if (Connection.Exists<UserRow>(UserRow.Fields.UserId == Convert.ToInt32(User.GetIdentifier())))
            {
                //throw new ValidationError("EmailInUse", Texts.Validation.CantFindUserWithEmail);
                var user = Connection.TryFirst<UserRow>(UserRow.Fields.UserId == Convert.ToInt32(User.GetIdentifier()));
                

                var serialkeyrow = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);
                PlayListRow playList = Connection.Single<PlayListRow>(PlayListRow.Fields.Id == serialkeyrow.PlayListId.Value);
                var teacher = Connection.TryFirst<TeacherRow>(TeacherRow.Fields.Id == playList.TeacherId.Value);

                //CHECK FOR SERIALKEY
                var activation = Connection.TryFirst<ActivationRow>(ActivationRow.Fields.SerialKeyId == serialkeyrow.Id.Value && ActivationRow.Fields.PlayListId == serialkeyrow.PlayListId.Value && ActivationRow.Fields.TeacherId == Convert.ToInt32(User.GetIdentifier()));
                if (activation != null)
                {
                    throw new ValidationError("ERROR: Teacher already have activated SerialKey " + serialkeyrow.SerialKey + " for " + playList.Title);
                }
                else
                {
                    if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.EStatus == Convert.ToInt32(EKeyStatus.OPEN) && SerialKeyRow.Fields.SerialKey == Row.SerialKey))
                    {
                        SerialKeyRow productSerial = Connection.Single<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);

                        // Check if productSerial is not null
                        if (productSerial != null)
                        {
                            var serialId = Convert.ToInt32(productSerial.Id);
                            var playlist = Connection.TryFirst<PlayListRow>(PlayListRow.Fields.Id == productSerial.PlayListId.Value);


                            // Check if the referenced SerialKeyRow exists before inserting into ActivationRow
                            if (Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.Id == serialId))
                            {
                                int activationId = (int)Connection.InsertAndGetID(new ActivationRow()
                                {
                                    SerialKeyId = serialId,
                                    TeacherId = teacher.Id,
                                    PlayListId = playList.Id,
                                    EStatus = EKeyStatus.ACTIVATED,
                                    InsertDate = DateTime.Now,
                                    InsertUserId = Convert.ToInt32(User.GetIdentifier()),
                                    IsActive = 1
                                });
                                ActvtnId = activationId;

                                productSerial.EStatus = EKeyStatus.ACTIVATED;
                                Connection.UpdateById(productSerial);
                                Row.Code = Row.SerialKey;
                                Row.PlayListId = playList.Id;
                                Row.Note = "Serial Key: " + Row.SerialKey + " is Successfully Activated!!";
                                // ...
                            }
                            else
                            {
                                // Handle the case where the referenced SerialKeyRow does not exist
                                Row.Note = "ERROR: Referenced SerialKeyRow does not exist";

                            }
                        }
                        else
                        {
                            // Handle the case where productSerial is null
                            Row.Note = "ERROR: SerialKey not found";

                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(Row.Note))
                            Row.Note = "ERROR: SerialKey not available for activation!";

                    }
                }
            }
        }

        if (!Connection.Exists<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey))
        {
            Row.Note = "ERROR:Serial does not exist ";
        }
    }
    protected override void AfterSave()
    {
        base.AfterSave();
        if (IsCreate)
        {

            var serialkey = Connection.TryFirst<SerialKeyRow>(SerialKeyRow.Fields.SerialKey == Row.SerialKey);


            var actvation = Connection.TryFirst<ActivationRow>(ActivationRow.Fields.Id == ActvtnId);
            if (actvation != null)
            {

                Connection.UpdateById<ActivationRow>(actvation);
                Response.EntityId = ActvtnId;
            }
        }

    }
}