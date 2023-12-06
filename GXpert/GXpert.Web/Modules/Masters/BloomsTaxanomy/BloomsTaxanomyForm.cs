using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.BloomsTaxanomy")]
[BasedOnRow(typeof(BloomsTaxanomyRow), CheckNames = true)]
public class BloomsTaxanomyForm
{
    public string CoginitiveSkill { get; set; }
    public int SortOrder { get; set; }
}