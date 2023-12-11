using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.PlayList")]
[BasedOnRow(typeof(PlayListRow), CheckNames = true)]
public class PlayListForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public int TeacherId { get; set; }
    public string PlayListFilePath { get; set; }
    public int PlayListVersion { get; set; }
}