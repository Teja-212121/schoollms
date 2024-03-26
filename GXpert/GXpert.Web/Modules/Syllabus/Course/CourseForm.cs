using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Course")]
[BasedOnRow(typeof(CourseRow), CheckNames = true)]
public class CourseForm
{
    public string Title { get; set; }
    public short SortOrder { get; set; }
    public string Thumbnail { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
  
}