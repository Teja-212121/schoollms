using GXpert.Web.Enums;
using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.ContentAssignToPlayListcontentForm")]
//[BasedOnRow(typeof(PlayListContentRow), CheckNames = true)]
public class ContentAssignToPlayListcontentForm
{
    [HideOnInsert, HideOnUpdate]
    public String RowIds { get; set; }
    [HalfWidth]
    [Required]
    public EPlayListContentType? EContentType { get; set; }
   
    [LookupEditor("Playlist.PlayList"), HalfWidth]
    public int PlayListId { get; set; }
    [LookupEditor("Content.Content"), HalfWidth]

    public int ContentId { get; set; }
    [LookupEditor("Exams.Exam"), HalfWidth]
  
    public int ExamId { get; set; }
    [LookupEditor("LiveSessions.LiveSession"), HalfWidth]
    public int LiveSessionId { get; set; }
    [LookupEditor("Exams.Assignment"), HalfWidth]
    public int AssignmentId { get; set; }
    [LookupEditor("Playlist.Module"), HalfWidth]
    public int ModuleId { get; set; }
    [HalfWidth]
    [Required]
    public EExamStatus? EPublishStatus { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
}