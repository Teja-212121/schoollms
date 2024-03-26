using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicYear")]
[BasedOnRow(typeof(AcademicYearRow), CheckNames = true)]
public class AcademicYearForm
{
    public string Name { get; set; }
    [HalfWidth]
    public DateTime StartDate { get; set; }
    [HalfWidth]
    public DateTime EndDate { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
   
}