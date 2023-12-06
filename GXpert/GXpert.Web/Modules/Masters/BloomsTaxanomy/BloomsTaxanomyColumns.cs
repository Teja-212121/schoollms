using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.BloomsTaxanomy")]
[BasedOnRow(typeof(BloomsTaxanomyRow), CheckNames = true)]
public class BloomsTaxanomyColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string CoginitiveSkill { get; set; }
    public int SortOrder { get; set; }
}