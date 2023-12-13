using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.School")]
[BasedOnRow(typeof(SchoolRow), CheckNames = true)]
public class SchoolForm
{
    [HalfWidth]
    public string Name { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    [HalfWidth]
    public short EType { get; set; }
    [HalfWidth]
    public string Address { get; set; }
    [HalfWidth]
    public string City { get; set; }
    [HalfWidth]
    public int StateId { get; set; }
    [HalfWidth]
    public int DistrictId { get; set; }
    [HalfWidth]
    public int TalukaId { get; set; }
    [HalfWidth]
    public string LocationInfo { get; set; }
    [HalfWidth]
    public DateTime EstablishmentDate { get; set; }
}