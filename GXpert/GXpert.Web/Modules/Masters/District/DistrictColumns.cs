using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.District")]
[BasedOnRow(typeof(DistrictRow), CheckNames = true)]
public class DistrictColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    [QuickFilter]
    public string StateTitle { get; set; }
    public string ShortName { get; set; }
}