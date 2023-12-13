using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolStudent")]
[BasedOnRow(typeof(SchoolStudentRow), CheckNames = true)]
public class SchoolStudentForm
{
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public int SchoolId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public string Division { get; set; }
    [HalfWidth]
    public string RollNumber { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    [HalfWidth]
    public int AcademicYearId { get; set; }
}