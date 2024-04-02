using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Analytics;

[ConnectionKey("Default"), Module("Analytics"), TableName("AnalyticsLog")]
[DisplayName("Analytics Log"), InstanceName("Analytics Log")]
[ReadPermission(PermissionKeys.AnalyticsManagement.View)]
[ModifyPermission(PermissionKeys.AnalyticsManagement.Modify)]
    [LookupScript("Analytics.AnalyticsLog",Permission ="*")]
public sealed class AnalyticsLogRow : LoggingRow<AnalyticsLogRow.RowFields>, IIdRow
{
    const string jContent = nameof(jContent);
    const string jActivation = nameof(jActivation);
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey("Contents", "Id"), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor("Content.Content")]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Start Datetime"), NotNull]
    public DateTime? StartDatetime { get => fields.StartDatetime[this]; set => fields.StartDatetime[this] = value; }

    [DisplayName("End Date Time"), NotNull]
    public DateTime? EndDateTime { get => fields.EndDateTime[this]; set => fields.EndDateTime[this] = value; }

    [DisplayName("Time Spent"), NotNull]
    public int? TimeSpent { get => fields.TimeSpent[this]; set => fields.TimeSpent[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Expression($"{jContent}.[Title]")]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ContentId;
        public Int32Field ActivationId;
        public Int32Field StudentId;
        public DateTimeField StartDatetime;
        public DateTimeField EndDateTime;
        public Int32Field TimeSpent;
        public BooleanField IsActive;

        public StringField ContentTitle;
        public StringField ActivationDeviceId;
        public StringField StudentPrn;
    }
}