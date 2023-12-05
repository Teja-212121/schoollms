using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.RaiseHandLiveSession")]
[BasedOnRow(typeof(RaiseHandLiveSessionRow), CheckNames = true)]
public class RaiseHandLiveSessionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int LiveSessionlogId { get; set; }
    public string StudentPrn { get; set; }
    public DateTime SessionTime { get; set; }
    public short HandRaiseStatus { get; set; }
    public string PlayListTitle { get; set; }
    public string ActivationDeviceId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}