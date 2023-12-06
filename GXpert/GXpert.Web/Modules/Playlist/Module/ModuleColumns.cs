using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Playlist.Columns;

[ColumnsScript("Playlist.Module")]
[BasedOnRow(typeof(ModuleRow), CheckNames = true)]
public class ModuleColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public string ParentTitle { get; set; }
    public float SortOrder { get; set; }
}