using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.Assignment")]
[BasedOnRow(typeof(AssignmentRow), CheckNames = true)]
public class AssignmentForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string File { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
}