using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("AssignmentAttemptEvaluations")]
[DisplayName("Assignment Attempt Evaluation"), InstanceName("Assignment Attempt Evaluation"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class AssignmentAttemptEvaluationRow : Row<AssignmentAttemptEvaluationRow.RowFields>, IIdRow
{
    const string jAssignment = nameof(jAssignment);
    const string jAssignmentAttempt = nameof(jAssignmentAttempt);
    const string jAssignmentEvaluation = nameof(jAssignmentEvaluation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Assignment"), NotNull, ForeignKey("Assignments", "Id"), LeftJoin(jAssignment), TextualField(nameof(AssignmentTitle))]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Assignment Attempt"), NotNull, ForeignKey(typeof(AssignmentAttemptRow)), LeftJoin(jAssignmentAttempt)]
    [TextualField(nameof(AssignmentAttemptFileUploaded)), ServiceLookupEditor(typeof(AssignmentAttemptRow))]
    public int? AssignmentAttemptId { get => fields.AssignmentAttemptId[this]; set => fields.AssignmentAttemptId[this] = value; }

    [DisplayName("Assignment Evaluation"), ForeignKey("AssignmentEvaluation", "Id"), LeftJoin(jAssignmentEvaluation)]
    [TextualField(nameof(AssignmentEvaluationEvalutionCriteria))]
    public int? AssignmentEvaluationId { get => fields.AssignmentEvaluationId[this]; set => fields.AssignmentEvaluationId[this] = value; }

    [DisplayName("Marks Obtained"), NotNull]
    public int? MarksObtained { get => fields.MarksObtained[this]; set => fields.MarksObtained[this] = value; }

    [DisplayName("Evaluation Status"), NotNull]
    public short? EvaluationStatus { get => fields.EvaluationStatus[this]; set => fields.EvaluationStatus[this] = value; }

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

    [DisplayName("Assignment Title"), Expression($"{jAssignment}.[Title]")]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Assignment Attempt File Uploaded"), Origin(jAssignmentAttempt, nameof(AssignmentAttemptRow.FileUploaded))]
    public string AssignmentAttemptFileUploaded { get => fields.AssignmentAttemptFileUploaded[this]; set => fields.AssignmentAttemptFileUploaded[this] = value; }

    [DisplayName("Assignment Evaluation Evalution Criteria"), Expression($"{jAssignmentEvaluation}.[EvalutionCriteria]")]
    public string AssignmentEvaluationEvalutionCriteria { get => fields.AssignmentEvaluationEvalutionCriteria[this]; set => fields.AssignmentEvaluationEvalutionCriteria[this] = value; }
}