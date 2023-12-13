using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicYear")]
[BasedOnRow(typeof(AcademicYearRow), CheckNames = true)]
public class AcademicYearForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}