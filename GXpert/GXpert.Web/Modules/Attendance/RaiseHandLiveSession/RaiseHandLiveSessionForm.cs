using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.RaiseHandLiveSession")]
[BasedOnRow(typeof(RaiseHandLiveSessionRow), CheckNames = true)]
public class RaiseHandLiveSessionForm
{
    public int LiveSessionlogId { get; set; }
    public int StudentId { get; set; }
    public DateTime SessionTime { get; set; }
    public short HandRaiseStatus { get; set; }
    public int PlayListId { get; set; }
    public int ActivationId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}