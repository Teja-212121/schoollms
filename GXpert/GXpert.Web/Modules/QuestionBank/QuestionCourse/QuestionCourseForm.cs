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
    public int UserId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}