using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.PollResponse")]
[BasedOnRow(typeof(PollResponseRow), CheckNames = true)]
public class PollResponseForm
{
    [HalfWidth]
    public int PollId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public string Response { get; set; }
    [HalfWidth]
    public int ResponseTimeInSeconds { get; set; }
    [HalfWidth]
    public int Score { get; set; }
    [HalfWidth]
    public int LiveSessionLogId { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
}