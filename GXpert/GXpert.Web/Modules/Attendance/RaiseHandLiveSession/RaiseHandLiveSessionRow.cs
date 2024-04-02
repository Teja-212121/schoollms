using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("RaisehandLiveSessions")]
[DisplayName("Raise Hand Live Session"), InstanceName("Raise Hand Live Session")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
public sealed class RaiseHandLiveSessionRow : LoggingRow<RaiseHandLiveSessionRow.RowFields>, IIdRow
{
    const string jLiveSessionlog = nameof(jLiveSessionlog);
    const string jStudent = nameof(jStudent);
    const string jPlayList = nameof(jPlayList);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Live Sessionlog"), Column("liveSessionlogId"), NotNull, ForeignKey("LiveSessionLog", "Id"), LeftJoin(jLiveSessionlog)]
    [LookupEditor("LiveSessions.LiveSessionLog")]
    public int? LiveSessionlogId { get => fields.LiveSessionlogId[this]; set => fields.LiveSessionlogId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Session Time")]
    public DateTime? SessionTime { get => fields.SessionTime[this]; set => fields.SessionTime[this] = value; }

    [DisplayName("Hand Raise Status")]
    public EHandRaiseStatus? HandRaiseStatus { get => (EHandRaiseStatus?)fields.HandRaiseStatus[this]; set => fields.HandRaiseStatus[this] = (short?)value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field LiveSessionlogId;
        public Int32Field StudentId;
        public DateTimeField SessionTime;
        public Int16Field HandRaiseStatus;
        public Int32Field PlayListId;
        public Int32Field ActivationId;
        public BooleanField IsActive;

        public StringField StudentPrn;
        public StringField PlayListTitle;
        public StringField ActivationDeviceId;
    }
}