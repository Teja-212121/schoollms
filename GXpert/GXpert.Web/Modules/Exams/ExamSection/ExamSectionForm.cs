using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamSection")]
[BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
public class ExamSectionForm
{
    public int ExamId { get; set; }
    public string Title { get; set; }
    public string Instructions { get; set; }
    public int DurationInSeconds { get; set; }
    public float SortOrder { get; set; }
    public int ParentId { get; set; }
    public int NumberOfQuestions { get; set; }
    public int NumberOfMandatoryQuestions { get; set; }
    public string SearchTags { get; set; }
}