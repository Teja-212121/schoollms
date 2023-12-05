using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.Exam")]
[BasedOnRow(typeof(ExamRow), CheckNames = true)]
public class ExamForm
{
    public string Title { get; set; }
    public short EExamType { get; set; }
    public short EExamState { get; set; }
    public string QuestionPaperPath { get; set; }
    public string ModelAnswerPaperPath { get; set; }
    public int ExamDuration { get; set; }
    public float MaxMarks { get; set; }
    public float NegativeMarks { get; set; }
    public short EExamNavigation { get; set; }
    public short ESectionNavigation { get; set; }
    public short EQuestionNavigation { get; set; }
    public short EResultType { get; set; }
    public short EOptionDisplayType { get; set; }
    public bool HasNegativeMarketing { get; set; }
    public string Instructions { get; set; }
    public string SearchTags { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}