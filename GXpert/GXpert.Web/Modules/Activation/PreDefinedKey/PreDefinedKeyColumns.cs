using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Activation.Columns;

[ColumnsScript("Activation.PreDefinedKey")]
[BasedOnRow(typeof(PreDefinedKeyRow), CheckNames = true)]
public class PreDefinedKeyColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SerialKey { get; set; }
    public short EStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}