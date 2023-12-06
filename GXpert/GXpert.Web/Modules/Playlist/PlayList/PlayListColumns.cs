using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Playlist.Columns;

[ColumnsScript("Playlist.PlayList")]
[BasedOnRow(typeof(PlayListRow), CheckNames = true)]
public class PlayListColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TeacherPrn { get; set; }
}