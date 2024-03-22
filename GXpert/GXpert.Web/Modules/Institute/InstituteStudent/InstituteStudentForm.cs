using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteStudent")]
[BasedOnRow(typeof(InstituteStudentRow), CheckNames = true)]
public class InstituteStudentForm
{
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
    public int AcademicYearId { get; set; }
   
}