using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentBloomsIndex")]
[BasedOnRow(typeof(ContentBloomsIndexRow), CheckNames = true)]
public class ContentBloomsIndexForm
{
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int BloomsIndex { get; set; }
    [HalfWidth]
    public float Weightage { get; set; }
}