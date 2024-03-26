using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Semester")]
[BasedOnRow(typeof(SemesterRow), CheckNames = true)]
public class SemesterForm
{
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public string Title { get; set; }
    [HalfWidth]
    public short SortOrder { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    


}