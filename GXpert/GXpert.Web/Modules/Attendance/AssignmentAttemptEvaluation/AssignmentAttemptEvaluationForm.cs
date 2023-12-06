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
}