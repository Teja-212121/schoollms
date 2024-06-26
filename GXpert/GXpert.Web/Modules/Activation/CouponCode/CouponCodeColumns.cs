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
    [QuickFilter]
    public short ValidityType { get; set; }
    [QuickFilter]
    public short CountType { get; set; }
    public short Count { get; set; }
    public short ValidityInDays { get; set; }
    public DateTime ValidDate { get; set; }
    public int ConsumedCount { get; set; }
    public DateTime CouponValidityDate { get; set; }
}