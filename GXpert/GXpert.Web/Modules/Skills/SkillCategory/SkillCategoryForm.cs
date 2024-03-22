using Serenity.ComponentModel;
using System;

namespace GXpert.Skills.Forms;

[FormScript("Skills.SkillCategory")]
[BasedOnRow(typeof(SkillCategoryRow), CheckNames = true)]
public class SkillCategoryForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
  
}