using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentCourse")]
[BasedOnRow(typeof(ContentCourseRow), CheckNames = true)]
public class ContentCourseColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ContentTitle { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public string Username { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}