using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.PlayListContent")]
[BasedOnRow(typeof(PlayListContentRow), CheckNames = true)]
public class PlayListContentForm
{
    public int PlayListId { get; set; }
    public int ContentId { get; set; }
    public int ExamId { get; set; }
    public int LiveSessionId { get; set; }
    public int AssignmentId { get; set; }
    public int ModuleId { get; set; }
    public float SortOrder { get; set; }
    public short EPublishStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}