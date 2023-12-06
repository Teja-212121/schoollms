using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions.Columns;

[ColumnsScript("LiveSessions.LiveSession")]
[BasedOnRow(typeof(LiveSessionRow), CheckNames = true)]
public class LiveSessionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string MeetingId { get; set; }
    public short LiveProvider { get; set; }
    public string Password { get; set; }
    public string Secret { get; set; }
    public string LiveAdditionalInfo { get; set; }
    public string SearchTags { get; set; }
}