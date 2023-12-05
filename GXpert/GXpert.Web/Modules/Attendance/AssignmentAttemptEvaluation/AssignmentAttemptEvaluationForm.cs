using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.AssignmentAttemptEvaluation")]
[BasedOnRow(typeof(AssignmentAttemptEvaluationRow), CheckNames = true)]
public class AssignmentAttemptEvaluationForm
{
    public int AssignmentId { get; set; }
    public int AssignmentAttemptId { get; set; }
    public int AssignmentEvaluationId { get; set; }
    public int MarksObtained { get; set; }
    public short EvaluationStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}