using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions.Columns;

[ColumnsScript("LiveSessions.Poll")]
[BasedOnRow(typeof(PollRow), CheckNames = true)]
public class PollColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Question { get; set; }
    public short EQuestionType { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public string Option4 { get; set; }
    public string Option5 { get; set; }
    public string RightAnswer { get; set; }
    public int LiveSessionLogId { get; set; }
    public short TotalAttempts { get; set; }
    public float AverageResponseTime { get; set; }
    public short NumberOfCorrect { get; set; }
    public short NumberOfWrong { get; set; }
    public string BloomsTaxonomyCoginitiveSkill { get; set; }
    public float Weightage { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}