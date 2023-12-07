using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentTopic")]
[BasedOnRow(typeof(ContentTopicRow), CheckNames = true)]
public class ContentTopicColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [QuickFilter]
    public string ContentTitle { get; set; }
    [QuickFilter]
    public string ClassTitle { get; set; }
    [QuickFilter]
    public string SubjectTitle { get; set; }
    [QuickFilter]
    public string TopicTitle { get; set; }
    [QuickFilter]
    public string MediumTitle { get; set; }
    public short SortOrder { get; set; }
}