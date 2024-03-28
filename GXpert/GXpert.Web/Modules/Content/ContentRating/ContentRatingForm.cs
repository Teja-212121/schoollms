using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentRating")]
[BasedOnRow(typeof(ContentRatingRow), CheckNames = true)]
public class ContentRatingForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
   
}