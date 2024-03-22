using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Skills.Columns;

[ColumnsScript("Skills.SkillCategory")]
[BasedOnRow(typeof(SkillCategoryRow), CheckNames = true)]
public class SkillCategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
  
}