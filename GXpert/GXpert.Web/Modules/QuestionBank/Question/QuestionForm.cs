using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionForm
{
    public string QuestionText { get; set; }
    public string Explaination { get; set; }
    [HalfWidth]
    public bool IsSubjective { get; set; }
    [HalfWidth]
    public short EQuestionType { get; set; }
    [HalfWidth]
    public short EDifficultyLevel { get; set; }
    [HalfWidth]
    public int QuestionCommonDataId { get; set; }
    [HalfWidth]
    public float QuestionCommonDataSortOrder { get; set; }
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