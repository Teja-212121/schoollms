using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.PollResponse")]
[BasedOnRow(typeof(PollResponseRow), CheckNames = true)]
public class PollResponseForm
{
    public int PollId { get; set; }
    public int StudentId { get; set; }
    public string Response { get; set; }
    public int ResponseTimeInSeconds { get; set; }
    public int Score { get; set; }
    public int LiveSessionLogId { get; set; }
    public int ActivationId { get; set; }
}