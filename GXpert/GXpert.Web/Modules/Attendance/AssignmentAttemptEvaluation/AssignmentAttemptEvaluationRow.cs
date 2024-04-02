using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("AssignmentAttemptEvaluations")]
[DisplayName("Assignment Attempt Evaluation"), InstanceName("Assignment Attempt Evaluation")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
public sealed class AssignmentAttemptEvaluationRow : LoggingRow<AssignmentAttemptEvaluationRow.RowFields>, IIdRow
{
    const string jAssignment = nameof(jAssignment);
    const string jAssignmentAttempt = nameof(jAssignmentAttempt);
    const string jAssignmentEvaluation = nameof(jAssignmentEvaluation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Assignment"), NotNull, ForeignKey("Assignments", "Id"), LeftJoin(jAssignment), TextualField(nameof(AssignmentTitle))]
    [LookupEditor("Exams.Assignment")]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Assignment Attempt"), NotNull, ForeignKey(typeof(AssignmentAttemptRow)), LeftJoin(jAssignmentAttempt)]
    [TextualField(nameof(AssignmentAttemptFileUploaded)), ServiceLookupEditor(typeof(AssignmentAttemptRow))]
    public int? AssignmentAttemptId { get => fields.AssignmentAttemptId[this]; set => fields.AssignmentAttemptId[this] = value; }

    [DisplayName("Assignment Evaluation"), ForeignKey("AssignmentEvaluation", "Id"), LeftJoin(jAssignmentEvaluation)]
    [TextualField(nameof(AssignmentEvaluationEvalutionCriteria))]
    [LookupEditor("Exams.AssignmentEvaluation")]
    public int? AssignmentEvaluationId { get => fields.AssignmentEvaluationId[this]; set => fields.AssignmentEvaluationId[this] = value; }

    [DisplayName("Marks Obtained"), NotNull]
    public int? MarksObtained { get => fields.MarksObtained[this]; set => fields.MarksObtained[this] = value; }

    [DisplayName("Evaluation Status"), NotNull]
    public EExamAttemptStatus? EvaluationStatus { get => (EExamAttemptStatus?)fields.EvaluationStatus[this]; set => fields.EvaluationStatus[this] = (short?)value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Assignment Title"), Expression($"{jAssignment}.[Title]")]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Assignment Attempt File Uploaded"), Origin(jAssignmentAttempt, nameof(AssignmentAttemptRow.FileUploaded))]
    public string AssignmentAttemptFileUploaded { get => fields.AssignmentAttemptFileUploaded[this]; set => fields.AssignmentAttemptFileUploaded[this] = value; }

    [DisplayName("Assignment Evaluation Evalution Criteria"), Expression($"{jAssignmentEvaluation}.[EvalutionCriteria]")]
    public string AssignmentEvaluationEvalutionCriteria { get => fields.AssignmentEvaluationEvalutionCriteria[this]; set => fields.AssignmentEvaluationEvalutionCriteria[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field AssignmentId;
        public Int32Field AssignmentAttemptId;
        public Int32Field AssignmentEvaluationId;
        public Int32Field MarksObtained;
        public Int16Field EvaluationStatus;
        public BooleanField IsActive;

        public StringField AssignmentTitle;
        public StringField AssignmentAttemptFileUploaded;
        public StringField AssignmentEvaluationEvalutionCriteria;
    }
}