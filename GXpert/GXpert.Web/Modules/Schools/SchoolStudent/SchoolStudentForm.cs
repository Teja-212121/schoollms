using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolStudent")]
[BasedOnRow(typeof(SchoolStudentRow), CheckNames = true)]
public class SchoolStudentForm
{
    public int StudentId { get; set; }
    public int SchoolId { get; set; }
    public int ClassId { get; set; }
    public string Division { get; set; }
    public string RollNumber { get; set; }
    public string Description { get; set; }
    public int AcademicYearId { get; set; }
}