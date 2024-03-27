using Serenity.ComponentModel;

namespace GXpert.Masters.Forms;

[FormScript("Masters.UserSkillsScore")]
[BasedOnRow(typeof(UserSkillsScoreRow), CheckNames = true)]
public class UserSkillsScoreForm
{
    public int SkillCategoryId { get; set; }
    public int SkillId { get; set; }
    public float Score { get; set; }   
}