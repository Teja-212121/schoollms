using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentMediaRating")]
[BasedOnRow(typeof(ContentMediaRatingRow), CheckNames = true)]
public class ContentMediaRatingForm
{
    public int ContentId { get; set; }
    public int RatingId { get; set; }
    public short Score { get; set; }
    public int UserId { get; set; }
    
}