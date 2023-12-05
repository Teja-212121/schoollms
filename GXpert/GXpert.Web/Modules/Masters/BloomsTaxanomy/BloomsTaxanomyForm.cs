using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.BloomsTaxanomy")]
[BasedOnRow(typeof(BloomsTaxanomyRow), CheckNames = true)]
public class BloomsTaxanomyForm
{
    public string CoginitiveSkill { get; set; }
    public int SortOrder { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}