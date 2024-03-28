using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus.Columns;

[ColumnsScript("Syllabus.Semester")]
[BasedOnRow(typeof(SemesterRow), CheckNames = true)]
public class SemesterColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [QuickFilter]
    public string CourseTitle { get; set; }
    [QuickFilter]
    public string ClassTitle { get; set; }
    [EditLink]
    public string Title { get; set; }
    public short SortOrder { get; set; }
    public string Description { get; set; }


}