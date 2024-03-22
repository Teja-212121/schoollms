using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.PreAcademic")]
[BasedOnRow(typeof(PreAcademicRow), CheckNames = true)]
public class PreAcademicColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string ExamName { get; set; }
    public string Description { get; set; }
    public string Thumbnail { get; set; }
   
}