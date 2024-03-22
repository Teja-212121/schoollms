using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.Institute")]
[BasedOnRow(typeof(InstituteRow), CheckNames = true)]
public class InstituteForm
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
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
    public int PrincipalId { get; set; }
}