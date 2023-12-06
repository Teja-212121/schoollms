using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Subject")]
[BasedOnRow(typeof(SubjectRow), CheckNames = true)]
public class SubjectForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short SortOrder { get; set; }
    public int ClassId { get; set; }
    public int MediumId { get; set; }
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
}