using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.RaiseHandRecordedSession")]
[BasedOnRow(typeof(RaiseHandRecordedSessionRow), CheckNames = true)]
public class RaiseHandRecordedSessionForm
{
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int PlayListContentId { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
}