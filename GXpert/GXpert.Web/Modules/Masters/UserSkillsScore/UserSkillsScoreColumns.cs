using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.UserSkillsScore")]
[BasedOnRow(typeof(UserSkillsScoreRow), CheckNames = true)]
public class UserSkillsScoreColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string SkillCategoryName { get; set; }
    public string SkillName { get; set; }
    public float Score { get; set; }   
}