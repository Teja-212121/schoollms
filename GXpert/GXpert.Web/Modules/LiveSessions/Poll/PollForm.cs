using Serenity.ComponentModel;
using System;

namespace GXpert.LiveSessions.Forms;

[FormScript("LiveSessions.Poll")]
[BasedOnRow(typeof(PollRow), CheckNames = true)]
public class PollForm
{

    public string Question { get; set; }
    [HalfWidth]
    public short EQuestionType { get; set; }
    [HalfWidth]
    public string Option1 { get; set; }
    [HalfWidth]
    public string Option2 { get; set; }
    [HalfWidth]
    public string Option3 { get; set; }
    [HalfWidth]
    public string Option4 { get; set; }
    [HalfWidth]
    public string Option5 { get; set; }
    [HalfWidth]
    public string RightAnswer { get; set; }
    [HalfWidth]
    public int LiveSessionLogId { get; set; }
    [HalfWidth]
    public short TotalAttempts { get; set; }
    [HalfWidth]
    public float AverageResponseTime { get; set; }
    [HalfWidth]
    public short NumberOfCorrect { get; set; }
    [HalfWidth]
    public short NumberOfWrong { get; set; }
    [HalfWidth]
    public int BloomsTaxonomyId { get; set; }
    [HalfWidth]
    public float Weightage { get; set; }
}