using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.RaiseHandRecordedSession")]
[BasedOnRow(typeof(RaiseHandRecordedSessionRow), CheckNames = true)]
public class RaiseHandRecordedSessionForm
{
    public int ContentId { get; set; }
    public int StudentId { get; set; }
    public int PlayListId { get; set; }
    public int PlayListContentId { get; set; }
    public int ActivationId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}