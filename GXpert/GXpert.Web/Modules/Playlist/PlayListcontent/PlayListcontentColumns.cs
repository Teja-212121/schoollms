using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Playlist.Columns;

[ColumnsScript("Playlist.PlayListContent")]
[BasedOnRow(typeof(PlayListContentRow), CheckNames = true)]
public class PlayListContentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string PlayListTitle { get; set; }
    public string ContentTitle { get; set; }
    public string ExamTitle { get; set; }
    public string LiveSessionMeetingId { get; set; }
    public string AssignmentTitle { get; set; }
    public string ModuleTitle { get; set; }
    public float SortOrder { get; set; }
    public short EPublishStatus { get; set; }
}