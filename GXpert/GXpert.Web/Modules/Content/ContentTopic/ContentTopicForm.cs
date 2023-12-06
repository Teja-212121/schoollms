using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentTopic")]
[BasedOnRow(typeof(ContentTopicRow), CheckNames = true)]
public class ContentTopicForm
{
    public int ContentId { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public int TopicId { get; set; }
    public int MediumId { get; set; }
    public short SortOrder { get; set; }
}