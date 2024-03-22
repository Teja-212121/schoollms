using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.ProjectSkill")]
[BasedOnRow(typeof(ProjectSkillRow), CheckNames = true)]
public class ProjectSkillColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string SkillCategoryName { get; set; }
    public string SkillName { get; set; }
    public string ProjectTitle { get; set; }
}