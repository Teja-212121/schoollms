using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.QuestionCourse")]
[BasedOnRow(typeof(QuestionCourseRow), CheckNames = true)]
public class QuestionCourseForm
{
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    public int SubjectId { get;set; }
    public int TopicId { get; set; }
    public long QuestionId { get; set; }
}