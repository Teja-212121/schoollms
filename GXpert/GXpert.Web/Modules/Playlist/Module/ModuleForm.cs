using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.Module")]
[BasedOnRow(typeof(ModuleRow), CheckNames = true)]
public class ModuleForm
{
    public string Title { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    public int ParentId { get; set; }
    public float SortOrder { get; set; }
}