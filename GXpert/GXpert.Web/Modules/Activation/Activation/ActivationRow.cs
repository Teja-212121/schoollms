using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("Activations")]
[DisplayName("Activation"), InstanceName("Activation")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Activation.Activation")]
public sealed class ActivationRow : LoggingRow<ActivationRow.RowFields>, IIdRow, INameRow
{
    const string jPlayList = nameof(jPlayList);
    const string jTeacher = nameof(jTeacher);
    const string jActivationLog = nameof(jActivationLog);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("Activation Log"), NotNull, ForeignKey(typeof(ActivationLogRow)), LeftJoin(jActivationLog)]
    [TextualField(nameof(ActivationLogCode)), ServiceLookupEditor(typeof(ActivationLogRow))]
    public int? ActivationLogId { get => fields.ActivationLogId[this]; set => fields.ActivationLogId[this] = value; }

    [DisplayName("Device Id"), Size(200), QuickSearch, NameProperty]
    public string DeviceId { get => fields.DeviceId[this]; set => fields.DeviceId[this] = value; }

    [DisplayName("Device Details"), Size(500)]
    public string DeviceDetails { get => fields.DeviceDetails[this]; set => fields.DeviceDetails[this] = value; }

    [DisplayName("Activation Date")]
    public DateTime? ActivationDate { get => fields.ActivationDate[this]; set => fields.ActivationDate[this] = value; }

    [DisplayName("Expiry Date")]
    public DateTime? ExpiryDate { get => fields.ExpiryDate[this]; set => fields.ExpiryDate[this] = value; }

    [DisplayName("E Status"), Column("eStatus")]
    public EKeyStatus? EStatus { get => (EKeyStatus?)fields.EStatus[this]; set => fields.EStatus[this] = (short?)value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("Activation Log Code"), Origin(jActivationLog, nameof(ActivationLogRow.Code))]
    public string ActivationLogCode { get => fields.ActivationLogCode[this]; set => fields.ActivationLogCode[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field PlayListId;
        public Int32Field TeacherId;
        public Int32Field ActivationLogId;
        public StringField DeviceId;
        public StringField DeviceDetails;
        public DateTimeField ActivationDate;
        public DateTimeField ExpiryDate;
        public Int16Field EStatus;
        public Int16Field IsActive;

        public StringField PlayListTitle;
        public StringField TeacherPrn;
        public StringField ActivationLogCode;
    }
}