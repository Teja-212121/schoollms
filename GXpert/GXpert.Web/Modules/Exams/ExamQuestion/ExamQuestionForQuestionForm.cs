using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamQuestionForQuestionForm")]
[BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
public class ExamQuestionForQuestionForm
{
    [HideOnInsert,HideOnUpdate]
    public string RowIds { get; set; }

    [HalfWidth]
    [LookupEditor("Exams.Exam")]
    [DisplayName("Exam")]
    public int ExamId { get; set; }

    [HalfWidth]
    [LookupEditor("Exams.Exam Section")]
    [DisplayName("ExamSection")]
    public int ExamSectionId { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
    [Required]
    public float Marks { get; set; }
}