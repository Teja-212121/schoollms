using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.PollResponse")]
[BasedOnRow(typeof(PollResponseRow), CheckNames = true)]
public class PollResponseColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string PollQuestion { get; set; }
    public string StudentPrn { get; set; }
    [EditLink]
    public string Response { get; set; }
    public int ResponseTimeInSeconds { get; set; }
    public int Score { get; set; }
    public int LiveSessionLogId { get; set; }
    public string ActivationDeviceId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}