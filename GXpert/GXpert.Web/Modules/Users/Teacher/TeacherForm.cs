using Serenity.ComponentModel;
using System;

namespace GXpert.Users.Forms;

[FormScript("Users.Teacher")]
[BasedOnRow(typeof(TeacherRow), CheckNames = true)]
public class TeacherForm
{
    [HalfWidth]
    public string Prn { get; set; }
    [HalfWidth]
    public string Name { get; set; }
    [HalfWidth]
    public string Email { get; set; }
    [HalfWidth]
    public string Mobile { get; set; }
    [HalfWidth]
    public int UserId { get; set; }
    
    [HalfWidth]
    public int StateId { get; set; }
    [HalfWidth]
    public int DistrictId { get; set; }
    [HalfWidth]
    public int TalukaId { get; set; }
    [HalfWidth]
    public DateTime Dob { get; set; }
    [HalfWidth]
    public int SchoolId { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
}