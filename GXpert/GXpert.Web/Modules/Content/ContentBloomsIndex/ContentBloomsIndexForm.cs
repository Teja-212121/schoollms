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
}