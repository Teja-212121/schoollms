using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus.Columns;

[ColumnsScript("Syllabus.Course")]
[BasedOnRow(typeof(CourseRow), CheckNames = true)]
public class CourseColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public short SortOrder { get; set; }
    public string Thumbnail { get; set; }
    public string Description { get; set; }
    
}