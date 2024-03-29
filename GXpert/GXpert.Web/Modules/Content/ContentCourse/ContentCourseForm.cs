using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentCourse")]
[BasedOnRow(typeof(ContentCourseRow), CheckNames = true)]
public class ContentCourseForm
{
    public int ContentId { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    
}