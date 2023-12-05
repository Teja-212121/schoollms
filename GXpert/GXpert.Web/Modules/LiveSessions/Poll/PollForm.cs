using Serenity.ComponentModel;
using System;

namespace GXpert.LiveSessions.Forms;

[FormScript("LiveSessions.Poll")]
[BasedOnRow(typeof(PollRow), CheckNames = true)]
public class PollForm
{
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
    public int BloomsTaxonomyId { get; set; }
    public float Weightage { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}