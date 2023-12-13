using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.Exam")]
[BasedOnRow(typeof(ExamRow), CheckNames = true)]
public class ExamForm
{
    public string Title { get; set; }
    [HalfWidth]
    public short EExamType { get; set; }
    [HalfWidth]
    public short EExamState { get; set; }
    public string QuestionPaperPath { get; set; }
    public string ModelAnswerPaperPath { get; set; }
    [HalfWidth]
    public int ExamDuration { get; set; }
    [HalfWidth]
    public float MaxMarks { get; set; }
    [HalfWidth]
    public float NegativeMarks { get; set; }
    [HalfWidth]
    public short EExamNavigation { get; set; }
    [HalfWidth]
    public short ESectionNavigation { get; set; }
    [HalfWidth]
    public short EQuestionNavigation { get; set; }
    [HalfWidth]
    public short EResultType { get; set; }
    [HalfWidth]
    public short EOptionDisplayType { get; set; }
    [HalfWidth]
    public bool HasNegativeMarketing { get; set; }
    public string Instructions { get; set; }
    [HalfWidth]
    public string SearchTags { get; set; }
}