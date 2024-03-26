using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus.Columns;

[ColumnsScript("Syllabus.Topic")]
[BasedOnRow(typeof(TopicRow), CheckNames = true)]
public class TopicColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [Width(100),QuickFilter]
    public string CourseName { get; set; }

    public string ClassTitle { get; set; }
    public string SemesterName { get; set; }
    [Width(100), QuickFilter]
    public string SubjectTitle { get; set; }
    [EditLink]
    public string Title { get; set; }
    public short SortOrder { get; set; }

    /*public string MediumTitle { get; set; }*/
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
    public string Description { get; set; }
   
}