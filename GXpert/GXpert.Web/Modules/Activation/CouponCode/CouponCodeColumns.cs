using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Activation.Columns;

[ColumnsScript("Activation.CouponCode")]
[BasedOnRow(typeof(CouponCodeRow), CheckNames = true)]
public class CouponCodeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Code { get; set; }
    public string PlayListTitle { get; set; }
    public short ValidityType { get; set; }
    public short CountType { get; set; }
    public short Count { get; set; }
    public short ValidityInDays { get; set; }
    public DateTime ValidDate { get; set; }
    public int ConsumedCount { get; set; }
    public DateTime CouponValidityDate { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}