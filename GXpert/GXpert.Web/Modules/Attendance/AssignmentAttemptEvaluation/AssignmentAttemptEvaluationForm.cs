using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.AssignmentAttemptEvaluation")]
[BasedOnRow(typeof(AssignmentAttemptEvaluationRow), CheckNames = true)]
public class AssignmentAttemptEvaluationForm
{
    [HalfWidth]
    public int AssignmentId { get; set; }
    [HalfWidth]
    public int AssignmentAttemptId { get; set; }
    [HalfWidth]
    public int AssignmentEvaluationId { get; set; }
    [HalfWidth]
    public int MarksObtained { get; set; }
    [HalfWidth]
    public short EvaluationStatus { get; set; }
}