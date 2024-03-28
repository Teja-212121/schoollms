using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionForm
{
    [Category("Question")]
    [HtmlContentEditor(Rows = 4), CssClass("fact")]
    public string QuestionText { get; set; }
    [HtmlContentEditor(Rows = 4), CssClass("fact")]
    public string Explaination { get; set; }
    
    [Category("Question Attributes")]
    [HalfWidth, CssClass("fact")]
    public bool IsSubjective { get; set; }
    [HalfWidth, CssClass("fact")]
    public short EQuestionType { get; set; }
    [HalfWidth, CssClass("fact")]
    public short EDifficultyLevel { get; set; }
    [HalfWidth, CssClass("fact")]
    public int QuestionCommonDataId { get; set; }
    [HalfWidth, CssClass("fact")]
    public float QuestionCommonDataSortOrder { get; set; }
    [HalfWidth, CssClass("fact")]
    public int ClassId { get; set; }
    [HalfWidth, CssClass("fact")]
    public int SubjectId { get; set; }
    [HalfWidth, CssClass("fact")]
    public int TopicId { get; set; }
    [HalfWidth, CssClass("fact")]
    public int BloomsIndex { get; set; }
    [HalfWidth, CssClass("fact")]
    public float BloomsWeightage { get; set; }
    [Category("QuestionOption"), CssClass("fact")]
    [QuestionOptionEditor]
    public List<QuestionOptionRow> QuestionOptions { get; set; }
}