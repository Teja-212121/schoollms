using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.AssignmentEvaluation")]
[BasedOnRow(typeof(AssignmentEvaluationRow), CheckNames = true)]
public class AssignmentEvaluationForm
{
    public int AssignmentId { get; set; }
    public string EvalutionCriteria { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public int TopicId { get; set; }
    public int BloomsIndex { get; set; }
    public float BloomsWeightage { get; set; }
}