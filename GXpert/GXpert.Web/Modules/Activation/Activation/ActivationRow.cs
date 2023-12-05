using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("Activations")]
[DisplayName("Activation"), InstanceName("Activation"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class ActivationRow : Row<ActivationRow.RowFields>, IIdRow, INameRow
{
    const string jPlayList = nameof(jPlayList);
    const string jTeacher = nameof(jTeacher);
    const string jActivationLog = nameof(jActivationLog);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
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
    public short? EStatus { get => fields.EStatus[this]; set => fields.EStatus[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("Activation Log Code"), Origin(jActivationLog, nameof(ActivationLogRow.Code))]
    public string ActivationLogCode { get => fields.ActivationLogCode[this]; set => fields.ActivationLogCode[this] = value; }
}