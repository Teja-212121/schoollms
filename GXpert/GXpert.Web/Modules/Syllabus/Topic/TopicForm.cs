using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.Topic")]
[BasedOnRow(typeof(TopicRow), CheckNames = true)]
public class TopicForm
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    [HalfWidth]
    public short SortOrder { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }

    public int SemesterId { get; set; }
    /* [HalfWidth]
     public int MediumId { get; set; }*/
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public float Weightage { get; set; }
    public string Thumbnail { get; set; }
}