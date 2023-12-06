using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.AssignedExamTeachers")]
[BasedOnRow(typeof(AssignedExamTeachersRow), CheckNames = true)]
public class AssignedExamTeachersForm
{
    public int ExamId { get; set; }
    public int PlayListId { get; set; }
    public int TeacherId { get; set; }
}