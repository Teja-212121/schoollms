using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.AssignmentEvaluation")]
[BasedOnRow(typeof(AssignmentEvaluationRow), CheckNames = true)]
public class AssignmentEvaluationForm
{
    [HalfWidth]
    public int AssignmentId { get; set; }
    [HalfWidth]
    public string EvalutionCriteria { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TopicId { get; set; }
    [HalfWidth]
    public int BloomsIndex { get; set; }
    [HalfWidth]
    public float BloomsWeightage { get; set; }
}