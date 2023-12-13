using Serenity.ComponentModel;
using System;

namespace GXpert.LiveSessions.Forms;

[FormScript("LiveSessions.LiveSessionLog")]
[BasedOnRow(typeof(LiveSessionLogRow), CheckNames = true)]
public class LiveSessionLogForm
{
    [HalfWidth]
    public DateTime Date { get; set; }
    [HalfWidth]
    public DateTime StartTime { get; set; }
    [HalfWidth]
    public DateTime EndTime { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
}