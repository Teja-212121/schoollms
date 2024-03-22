using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Skills.Columns;

[ColumnsScript("Skills.Skill")]
[BasedOnRow(typeof(SkillRow), CheckNames = true)]
public class SkillColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public string SkillCategoryName { get; set; }
   
}