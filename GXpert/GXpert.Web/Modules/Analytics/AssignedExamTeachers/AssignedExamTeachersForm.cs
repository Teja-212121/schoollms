using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.AssignedExamTeachers")]
[BasedOnRow(typeof(AssignedExamTeachersRow), CheckNames = true)]
public class AssignedExamTeachersForm
{
    [HalfWidth]
    public int ExamId { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
}