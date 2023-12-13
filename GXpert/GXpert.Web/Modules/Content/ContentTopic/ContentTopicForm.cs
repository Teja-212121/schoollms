using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentTopic")]
[BasedOnRow(typeof(ContentTopicRow), CheckNames = true)]
public class ContentTopicForm
{
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TopicId { get; set; }
    [HalfWidth]
    public int MediumId { get; set; }
    [HalfWidth]
    public short SortOrder { get; set; }
}