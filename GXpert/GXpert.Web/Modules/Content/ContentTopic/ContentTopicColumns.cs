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
    public string ContentTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
    public string MediumTitle { get; set; }
    public short SortOrder { get; set; }
}