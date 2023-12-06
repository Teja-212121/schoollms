using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("ActivationLog")]
[DisplayName("Activation Log"), InstanceName("Activation Log")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Activation.ActivationLog")]
public sealed class ActivationLogRow : LoggingRow<ActivationLogRow.RowFields>, IIdRow, INameRow
{
    const string jTeacher = nameof(jTeacher);
    const string jPlayList = nameof(jPlayList);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Code"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Code { get => fields.Code[this]; set => fields.Code[this] = value; }

    [DisplayName("Serial Key"), Size(100), NotNull]
    public string SerialKey { get => fields.SerialKey[this]; set => fields.SerialKey[this] = value; }

    [DisplayName("Teacher"), ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Device Id"), Size(200)]
    public string DeviceId { get => fields.DeviceId[this]; set => fields.DeviceId[this] = value; }

    [DisplayName("Device Details"), Size(500)]
    public string DeviceDetails { get => fields.DeviceDetails[this]; set => fields.DeviceDetails[this] = value; }

    [DisplayName("E Status"), Column("eStatus")]
    public short? EStatus { get => fields.EStatus[this]; set => fields.EStatus[this] = value; }

    [DisplayName("Note"), Size(1000)]
    public string Note { get => fields.Note[this]; set => fields.Note[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Code;
        public StringField SerialKey;
        public Int32Field TeacherId;
        public Int32Field PlayListId;
        public StringField DeviceId;
        public StringField DeviceDetails;
        public Int16Field EStatus;
        public StringField Note;
        public Int16Field IsActive;

        public StringField TeacherPrn;
        public StringField PlayListTitle;
    }
}