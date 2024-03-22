using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Activation.Columns;

[ColumnsScript("Activation.Activation")]
[BasedOnRow(typeof(ActivationRow), CheckNames = true)]
public class ActivationColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string PlayListTitle { get; set; }
    public string TeacherPrn { get; set; }

    public string StudentName { get; set; }
    public string ActivationLogCode { get; set; }
    [EditLink]
    public string DeviceId { get; set; }
    public string DeviceDetails { get; set; }
    [QuickFilter]
    public DateTime ActivationDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    [QuickFilter]
    public short EStatus { get; set; }
}