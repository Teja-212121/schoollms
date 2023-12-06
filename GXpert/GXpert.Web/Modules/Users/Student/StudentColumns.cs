using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Users.Columns;

[ColumnsScript("Users.Student")]
[BasedOnRow(typeof(StudentRow), CheckNames = true)]
public class StudentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Prn { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Username { get; set; }
    public string Description { get; set; }
    public string StateTitle { get; set; }
    public string DistrictTitle { get; set; }
    public string TalukaTitle { get; set; }
    public DateTime Dob { get; set; }
    public string SchoolName { get; set; }
}