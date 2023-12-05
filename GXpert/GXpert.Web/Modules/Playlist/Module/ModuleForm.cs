using Serenity.ComponentModel;
using System;

namespace GXpert.Playlist.Forms;

[FormScript("Playlist.Module")]
[BasedOnRow(typeof(ModuleRow), CheckNames = true)]
public class ModuleForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int ParentId { get; set; }
    public float SortOrder { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}