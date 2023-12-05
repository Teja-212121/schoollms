using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.AssignmentAttemptEvaluation")]
[BasedOnRow(typeof(AssignmentAttemptEvaluationRow), CheckNames = true)]
public class AssignmentAttemptEvaluationColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string AssignmentTitle { get; set; }
    public string AssignmentAttemptFileUploaded { get; set; }
    public string AssignmentEvaluationEvalutionCriteria { get; set; }
    public int MarksObtained { get; set; }
    public short EvaluationStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}