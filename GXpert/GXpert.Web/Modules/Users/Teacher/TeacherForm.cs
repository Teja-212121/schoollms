using Serenity.ComponentModel;
using System;

namespace GXpert.Users.Forms;

[FormScript("Users.Teacher")]
[BasedOnRow(typeof(TeacherRow), CheckNames = true)]
public class TeacherForm
{
    public string Prn { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public int StateId { get; set; }
    public int DistrictId { get; set; }
    public int TalukaId { get; set; }
    public DateTime Dob { get; set; }
    public int SchoolId { get; set; }
}