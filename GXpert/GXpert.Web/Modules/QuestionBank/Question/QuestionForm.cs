using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionForm
{
    public string QuestionText { get; set; }
    public string Explaination { get; set; }
    public bool IsSubjective { get; set; }
    public short EQuestionType { get; set; }
    public short EDifficultyLevel { get; set; }
    public int QuestionCommonDataId { get; set; }
    public float QuestionCommonDataSortOrder { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public int TopicId { get; set; }
    public int BloomsIndex { get; set; }
    public float BloomsWeightage { get; set; }
}