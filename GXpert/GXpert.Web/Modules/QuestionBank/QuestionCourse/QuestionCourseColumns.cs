using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank.Columns;

[ColumnsScript("QuestionBank.QuestionCourse")]
[BasedOnRow(typeof(QuestionCourseRow), CheckNames = true)]
public class QuestionCourseColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
}
 
   