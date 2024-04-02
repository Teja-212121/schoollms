using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("RaisehandRecordedSessions")]
[DisplayName("Raise Hand Recorded Session"), InstanceName("Raise Hand Recorded Session")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
public sealed class RaiseHandRecordedSessionRow : LoggingRow<RaiseHandRecordedSessionRow.RowFields>, IIdRow
{
    const string jContent = nameof(jContent);
    const string jStudent = nameof(jStudent);
    const string jPlayList = nameof(jPlayList);
    const string jPlayListContent = nameof(jPlayListContent);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey("Contents", "Id"), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor("Content.Content")]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Play List Content"), NotNull, ForeignKey("PlayListContents", "Id"), LeftJoin(jPlayListContent)]
    [LookupEditor("Playlist.PlayListContent")]
    public int? PlayListContentId { get => fields.PlayListContentId[this]; set => fields.PlayListContentId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Expression($"{jContent}.[Title]")]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ContentId;
        public Int32Field StudentId;
        public Int32Field PlayListId;
        public Int32Field PlayListContentId;
        public Int32Field ActivationId;
        public BooleanField IsActive;

        public StringField ContentTitle;
        public StringField StudentPrn;
        public StringField PlayListTitle;
        public StringField ActivationDeviceId;
    }
}