using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Playlist.Columns;

[ColumnsScript("Playlist.PlayListcontent")]
[BasedOnRow(typeof(PlayListcontentRow), CheckNames = true)]
public class PlayListcontentColumns
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
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}