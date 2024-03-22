using Serenity.ComponentModel;
using System;

namespace GXpert.Users.Forms;

[FormScript("Users.Principal")]
[BasedOnRow(typeof(PrincipalRow), CheckNames = true)]
public class PrincipalForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public int UserId { get; set; }
    public int StateId { get; set; }
    public int DistrictId { get; set; }
    public int TalukaId { get; set; }
    public DateTime Dob { get; set; }
   
}