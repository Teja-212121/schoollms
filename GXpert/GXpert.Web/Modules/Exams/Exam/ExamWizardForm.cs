
using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamWizardForm")]
//[BasedOnRow(typeof(ExamRow), CheckNames = true)]
public class ExamWizardForm
{
    [Tab("Exam Details")]
    public string Title { get; set; }
    [HalfWidth]
    public short EExamType { get; set; }
    [HalfWidth]
    public short EExamState { get; set; }
    [HalfWidth]
    public string QuestionPaperPath { get; set; }
    [HalfWidth]
    public string ModelAnswerPaperPath { get; set; }
    [HalfWidth]
    public int ExamDuration { get; set; }
    [HalfWidth]
    public float MaxMarks { get; set; }
    [HalfWidth]
    public float NegativeMarks { get; set; }
 
    [HalfWidth]
    public short EResultType { get; set; }
  
    [HtmlContentEditor(Rows = 4), CssClass("fact")]
    public string Instructions { get; set; }
    [HalfWidth]
    public string SearchTags { get; set; }
    [Tab("Add Exam Sections")]
    [LabelWidth("0")]
    [ExamSectionEditor]
    public List<ExamSectionRow> ExamSection { get; set; }
    [Tab("Add Exam Questions")]
    [/*ExamQuestionsEditor*/ LabelWidth("0")]
    public List<ExamQuestionRow> ExamQuestions { get; set; }
}