using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Medium")]
[BasedOnRow(typeof(MediumRow), CheckNames = true)]
public class MediumForm
{
    public string Title { get; set; }
    public string Description { get; set; }
}