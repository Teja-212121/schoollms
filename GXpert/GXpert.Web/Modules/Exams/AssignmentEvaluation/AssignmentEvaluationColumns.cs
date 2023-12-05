using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Exams.Columns;

[ColumnsScript("Exams.AssignmentEvaluation")]
[BasedOnRow(typeof(AssignmentEvaluationRow), CheckNames = true)]
public class AssignmentEvaluationColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string AssignmentTitle { get; set; }
    [EditLink]
    public string EvalutionCriteria { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
    public string BloomsIndexCoginitiveSkill { get; set; }
    public float BloomsWeightage { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}