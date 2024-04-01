using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentCourse")]
[BasedOnRow(typeof(ContentCourseRow), CheckNames = true)]
public class ContentCourseForm
{
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TopicId { get; set; }

}