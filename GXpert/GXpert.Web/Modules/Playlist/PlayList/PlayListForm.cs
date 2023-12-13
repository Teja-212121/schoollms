using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.PlayList")]
[BasedOnRow(typeof(PlayListRow), CheckNames = true)]
public class PlayListForm
{
    public string Title { get; set; }
    
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    public string PlayListFilePath { get; set; }
    public int PlayListVersion { get; set; }
}