using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.RaiseHandRecordedSession")]
[BasedOnRow(typeof(RaiseHandRecordedSessionRow), CheckNames = true)]
public class RaiseHandRecordedSessionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ContentTitle { get; set; }
    public string StudentPrn { get; set; }
    public string PlayListTitle { get; set; }
    public int PlayListContentId { get; set; }
    public string ActivationDeviceId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}