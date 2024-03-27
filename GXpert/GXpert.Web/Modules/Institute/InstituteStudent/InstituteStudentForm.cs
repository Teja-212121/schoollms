using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteStudent")]
[BasedOnRow(typeof(InstituteStudentRow), CheckNames = true)]
public class InstituteStudentForm
{
    [HalfWidth]
    public int InstituteId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public int InstituteDivisionId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    
    [HalfWidth]
    public string RollNumber { get; set; }
    [HalfWidth]
    public int AcademicYearId { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    [HalfWidth]
    public DateTime StartDate { get; set; }
    [HalfWidth]
    public DateTime EndDate { get; set; }
}
    
   
