using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.Institute")]
[BasedOnRow(typeof(InstituteRow), CheckNames = true)]
public class InstituteForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    [HalfWidth]
    public short EType { get; set; }
    
    public string Address { get; set; }
    [HalfWidth]
    public string City { get; set; }
    [HalfWidth]
    public int StateId { get; set; }
    [HalfWidth]
    public int  DistrictId { get; set; }
    [HalfWidth]
    public int TalukaId { get; set; }
    [HalfWidth]

    [TextAreaEditor(Rows =5)]
    public string LocationInfo { get; set; }
    [HalfWidth]
    public DateTime EstablishmentDate { get; set; }
    [HalfWidth]
    
    public int PrincipalId { get; set; }
    
}