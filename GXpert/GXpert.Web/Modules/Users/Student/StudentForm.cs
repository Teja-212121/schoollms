using Serenity.ComponentModel;
using System;

namespace GXpert.Users.Forms;

[FormScript("Users.Student")]
[BasedOnRow(typeof(StudentRow), CheckNames = true)]
public class StudentForm
{
    [Category("Personal Info")]
    [HalfWidth]
    public string Prn { get; set; }
    [HalfWidth]
    public string Name { get; set; }
    [HalfWidth]
    public string Email { get; set; }
    [HalfWidth]
    public string Mobile { get; set; }
    [HalfWidth]
    public DateTime Dob { get; set; }
    [HalfWidth]
    public string Gender { get; set; }
    [HalfWidth]
    public int UserId { get; set; }
    [Category("Division")]
    [HalfWidth]
    public int InstituteId { get; set; }
    [HalfWidth]
    public int DivisionId { get; set; }
    [HalfWidth]
    public int DepartmentId { get; set; }
    [HalfWidth]
    public int BranchId { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public int CurrentAcademicYearId { get; set; }
    [Category("Address")]
    public string AddressLine1 { get; set; }
   
    public string AddressLine2 { get; set; }
    [HalfWidth]
    public int StateId { get; set; }
    [HalfWidth]
    public int DistrictId { get; set; }
    [HalfWidth]
    public int TalukaId { get; set; }
    
   
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
}