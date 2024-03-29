using Serenity.ComponentModel;
using System;

namespace GXpert.LiveSessions.Forms;

[FormScript("LiveSessions.LiveSession")]
[BasedOnRow(typeof(LiveSessionRow), CheckNames = true)]
public class LiveSessionForm
{
    [HalfWidth]
    public string MeetingId { get; set; }
    [HalfWidth]
    public string Title { get; set; }
    [HalfWidth]
    public short LiveProvider { get; set; }

    [HalfWidth]
    public string Password { get; set; }
    [HalfWidth]
    public string Secret { get; set; }
    public string LiveAdditionalInfo { get; set; }
    public string SearchTags { get; set; }
}