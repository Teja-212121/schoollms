using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.Department")]
[BasedOnRow(typeof(DepartmentRow), CheckNames = true)]
public class DepartmentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string InstituteName { get; set; }
    public string HODName { get; set; }
    public string Description { get; set; }
   
}