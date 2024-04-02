using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("PollResponses")]
[DisplayName("Poll Response"), InstanceName("Poll Response")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class PollResponseRow : LoggingRow<PollResponseRow.RowFields>, IIdRow, INameRow
{
    const string jPoll = nameof(jPoll);
    const string jStudent = nameof(jStudent);
    const string jLiveSessionLog = nameof(jLiveSessionLog);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Poll"), NotNull, ForeignKey("Polls", "Id"), LeftJoin(jPoll), TextualField(nameof(PollQuestion))]
    [LookupEditor("LiveSessions.Poll")]
    public int? PollId { get => fields.PollId[this]; set => fields.PollId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Response"), Size(255), QuickSearch, NameProperty]
    public string Response { get => fields.Response[this]; set => fields.Response[this] = value; }

    [DisplayName("Response Time In Seconds")]
    public int? ResponseTimeInSeconds { get => fields.ResponseTimeInSeconds[this]; set => fields.ResponseTimeInSeconds[this] = value; }

    [DisplayName("Score"), NotNull]
    public int? Score { get => fields.Score[this]; set => fields.Score[this] = value; }

    [DisplayName("Live Session Log"), NotNull, ForeignKey("LiveSessionLog", "Id"), LeftJoin(jLiveSessionLog)]
    [LookupEditor("LiveSessions.LiveSessionLog")]
    public int? LiveSessionLogId { get => fields.LiveSessionLogId[this]; set => fields.LiveSessionLogId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Poll Question"), Expression($"{jPoll}.[Question]")]
    public string PollQuestion { get => fields.PollQuestion[this]; set => fields.PollQuestion[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field PollId;
        public Int32Field StudentId;
        public StringField Response;
        public Int32Field ResponseTimeInSeconds;
        public Int32Field Score;
        public Int32Field LiveSessionLogId;
        public Int32Field ActivationId;
        public BooleanField IsActive;

        public StringField PollQuestion;
        public StringField StudentPrn;
        public StringField ActivationDeviceId;
    }
}