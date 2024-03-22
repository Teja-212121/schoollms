using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus.Columns;

[ColumnsScript("Syllabus.Class")]
[BasedOnRow(typeof(ClassRow), CheckNames = true)]
public class ClassColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    [Width(100),QuickFilter]
    public string CourseName { get; set; }
    public string Description { get; set; }
    public short SortOrder { get; set; }
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
}