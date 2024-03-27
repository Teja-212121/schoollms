using Serenity.ComponentModel;

namespace GXpert.Masters.Forms;

[FormScript("Masters.ProjectSkill")]
[BasedOnRow(typeof(ProjectSkillRow), CheckNames = true)]
public class ProjectSkillForm
{
    public int SkillCategoryId { get; set; }
    public int SkillId { get; set; }
    public int ProjectId { get; set; }
}