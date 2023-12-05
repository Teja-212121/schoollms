using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("PollResponses")]
[DisplayName("Poll Response"), InstanceName("Poll Response"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class PollResponseRow : Row<PollResponseRow.RowFields>, IIdRow, INameRow
{
    const string jPoll = nameof(jPoll);
    const string jStudent = nameof(jStudent);
    const string jLiveSessionLog = nameof(jLiveSessionLog);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Poll"), NotNull, ForeignKey("Polls", "Id"), LeftJoin(jPoll), TextualField(nameof(PollQuestion))]
    public int? PollId { get => fields.PollId[this]; set => fields.PollId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Response"), Size(255), QuickSearch, NameProperty]
    public string Response { get => fields.Response[this]; set => fields.Response[this] = value; }

    [DisplayName("Response Time In Seconds")]
    public int? ResponseTimeInSeconds { get => fields.ResponseTimeInSeconds[this]; set => fields.ResponseTimeInSeconds[this] = value; }

    [DisplayName("Score"), NotNull]
    public int? Score { get => fields.Score[this]; set => fields.Score[this] = value; }

    [DisplayName("Live Session Log"), NotNull, ForeignKey("LiveSessionLog", "Id"), LeftJoin(jLiveSessionLog)]
    public int? LiveSessionLogId { get => fields.LiveSessionLogId[this]; set => fields.LiveSessionLogId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Poll Question"), Expression($"{jPoll}.[Question]")]
    public string PollQuestion { get => fields.PollQuestion[this]; set => fields.PollQuestion[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }
}