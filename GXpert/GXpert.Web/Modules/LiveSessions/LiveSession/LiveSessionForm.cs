using Serenity.ComponentModel;
using System;

namespace GXpert.LiveSessions.Forms;

[FormScript("LiveSessions.LiveSession")]
[BasedOnRow(typeof(LiveSessionRow), CheckNames = true)]
public class LiveSessionForm
{
    public string MeetingId { get; set; }
    public short LiveProvider { get; set; }
    public string Password { get; set; }
    public string Secret { get; set; }
    public string LiveAdditionalInfo { get; set; }
    public string SearchTags { get; set; }
}