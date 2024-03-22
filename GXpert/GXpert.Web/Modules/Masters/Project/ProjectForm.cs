using Serenity.ComponentModel;

namespace GXpert.Masters.Forms;

[FormScript("Masters.Project")]
[BasedOnRow(typeof(ProjectRow), CheckNames = true)]
public class ProjectForm
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public short EType { get; set; }
}