using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions.Columns;

[ColumnsScript("LiveSessions.LiveSessionLog")]
[BasedOnRow(typeof(LiveSessionLogRow), CheckNames = true)]
public class LiveSessionLogColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string TeacherPrn { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
}