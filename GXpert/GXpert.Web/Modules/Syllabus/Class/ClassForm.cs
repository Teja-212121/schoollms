using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Class")]
[BasedOnRow(typeof(ClassRow), CheckNames = true)]
public class ClassForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short SortOrder { get; set; }
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
}