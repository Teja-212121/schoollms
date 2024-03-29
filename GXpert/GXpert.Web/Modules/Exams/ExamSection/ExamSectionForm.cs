using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamSection")]
[BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
public class ExamSectionForm
{
    [HalfWidth]
    public int ExamId { get; set; }

    public string Title { get; set; }
    public string Instructions { get; set; }
    [HalfWidth]
    public int DurationInSeconds { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
    [HalfWidth]
    public int ParentId { get; set; }
    [HalfWidth]
    public int NumberOfQuestions { get; set; }
    [HalfWidth]
    public int NumberOfMandatoryQuestions { get; set; }
    [HalfWidth]
    public string SearchTags { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TopicId { get; set; }
}