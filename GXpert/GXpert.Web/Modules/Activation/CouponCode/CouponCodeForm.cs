using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.CouponCode")]
[BasedOnRow(typeof(CouponCodeRow), CheckNames = true)]
public class CouponCodeForm
{
    [HalfWidth]
    public string Code { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public short ValidityType { get; set; }
    [HalfWidth]
    public short CountType { get; set; }
    [HalfWidth]
    public short Count { get; set; }
    [HalfWidth]
    public short ValidityInDays { get; set; }
    [HalfWidth]
    public DateTime ValidDate { get; set; }
    [HalfWidth]
    public int ConsumedCount { get; set; }
    [HalfWidth]
    public DateTime CouponValidityDate { get; set; }
}