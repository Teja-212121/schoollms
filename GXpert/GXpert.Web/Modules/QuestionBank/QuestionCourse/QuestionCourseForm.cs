using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.QuestionCourse")]
[BasedOnRow(typeof(QuestionCourseRow), CheckNames = true)]
public class QuestionCourseForm
{
    public long QuestionId { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
}