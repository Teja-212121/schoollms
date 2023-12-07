using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.RaiseHandLiveSession")]
[BasedOnRow(typeof(RaiseHandLiveSessionRow), CheckNames = true)]
public class RaiseHandLiveSessionForm
{
    [HalfWidth]
    public int LiveSessionlogId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public DateTime SessionTime { get; set; }
    [HalfWidth]
    public short HandRaiseStatus { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
}