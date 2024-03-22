using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.Institute")]
[BasedOnRow(typeof(InstituteRow), CheckNames = true)]
public class InstituteColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public short EType { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string StateTitle { get; set; }
    public string DistrictTitle { get; set; }
    public string TalukaTitle { get; set; }
    public string LocationInfo { get; set; }
    public DateTime EstablishmentDate { get; set; }
   
    public string PrincipalName { get; set; }
}