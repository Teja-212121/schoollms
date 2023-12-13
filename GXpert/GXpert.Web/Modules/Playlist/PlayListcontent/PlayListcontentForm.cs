using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.PlayListContent")]
[BasedOnRow(typeof(PlayListContentRow), CheckNames = true)]
public class PlayListContentForm
{
    [HalfWidth]
    public short EContentType { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int ExamId { get; set; }
    [HalfWidth]
    public int LiveSessionId { get; set; }
    [HalfWidth]
    public int AssignmentId { get; set; }
    [HalfWidth]
    public int ModuleId { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
    [HalfWidth]
    public short EPublishStatus { get; set; }
}