using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.Project")]
[BasedOnRow(typeof(ProjectRow), CheckNames = true)]
public class ProjectColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public short EType { get; set; }
}