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
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}