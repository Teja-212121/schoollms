using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Activation.Columns;

[ColumnsScript("Activation.SerialKey")]
[BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
public class SerialKeyColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SerialKey { get; set; }
    public string PlayListTitle { get; set; }
    public short ValidityType { get; set; }
    public short ValidityInDays { get; set; }
    public DateTime ValidDate { get; set; }
    public string Note { get; set; }
    public short EStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}