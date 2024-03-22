using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.Branch")]
[BasedOnRow(typeof(BranchRow), CheckNames = true)]
public class BranchColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string InstituteName { get; set; }
    public string DepartmentTitle { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
   
}