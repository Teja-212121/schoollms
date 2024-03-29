using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Exams.Columns;

[ColumnsScript("Exams.ExamQuestion")]
[BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
public class ExamQuestionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamTitle { get; set; }
    public string ExamSectionTitle { get; set; }
    public string QuestionText { get; set; }
    public short EDifficultyLevel { get; set; }
    [EditLink]
    public string RightAnswer { get; set; }
    public float Marks { get; set; }
    public float SortOrder { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
}