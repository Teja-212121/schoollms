using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolClass")]
[BasedOnRow(typeof(SchoolClassRow), CheckNames = true)]
public class SchoolClassForm
{
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public string Division { get; set; }
    [HalfWidth]
    public int MediumId { get; set; }
    [HalfWidth]
    public int ClassTeacherId { get; set; }
    [HalfWidth]
    public string Title { get; set; }
    [HalfWidth]
    public int AcademicYearId { get; set; }
}