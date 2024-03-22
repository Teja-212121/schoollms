using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Class")]
[BasedOnRow(typeof(ClassRow), CheckNames = true)]
public class ClassForm
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    [HalfWidth]
    public short SortOrder { get; set; }
    [HalfWidth]
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
}