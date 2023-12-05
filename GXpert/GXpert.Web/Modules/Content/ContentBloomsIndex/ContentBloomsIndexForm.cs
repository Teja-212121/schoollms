using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentBloomsIndex")]
[BasedOnRow(typeof(ContentBloomsIndexRow), CheckNames = true)]
public class ContentBloomsIndexForm
{
    public int ContentId { get; set; }
    public int BloomsIndex { get; set; }
    public float Weightage { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}