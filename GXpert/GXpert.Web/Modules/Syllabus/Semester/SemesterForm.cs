using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Semester")]
[BasedOnRow(typeof(SemesterRow), CheckNames = true)]
public class SemesterForm
{
    public string Title { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    
}