using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.Taluka")]
[BasedOnRow(typeof(TalukaRow), CheckNames = true)]
public class TalukaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string StateTitle { get; set; }
    public string DistrictTitle { get; set; }
    public string ShortName { get; set; }
}