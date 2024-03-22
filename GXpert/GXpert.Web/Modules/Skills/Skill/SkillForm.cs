using Serenity.ComponentModel;
using System;

namespace GXpert.Skills.Forms;

[FormScript("Skills.Skill")]
[BasedOnRow(typeof(SkillRow), CheckNames = true)]
public class SkillForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    public int SkillCategoryId { get; set; }
   
}