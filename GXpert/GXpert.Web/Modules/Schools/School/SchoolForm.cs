using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.School")]
[BasedOnRow(typeof(SchoolRow), CheckNames = true)]
public class SchoolForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public short EType { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public int StateId { get; set; }
    public int DistrictId { get; set; }
    public int TalukaId { get; set; }
    public string LocationInfo { get; set; }
    public DateTime EstablishmentDate { get; set; }
}