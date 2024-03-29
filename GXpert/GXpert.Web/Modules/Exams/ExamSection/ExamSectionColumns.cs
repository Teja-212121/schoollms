using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Exams.Columns;

[ColumnsScript("Exams.ExamSection")]
[BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
public class ExamSectionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamTitle { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Instructions { get; set; }
    public int DurationInSeconds { get; set; }
    public float SortOrder { get; set; }
    public string ParentTitle { get; set; }
    public int NumberOfQuestions { get; set; }
    public int NumberOfMandatoryQuestions { get; set; }
    public string SearchTags { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
}