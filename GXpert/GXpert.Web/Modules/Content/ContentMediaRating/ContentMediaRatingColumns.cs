using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentMediaRating")]
[BasedOnRow(typeof(ContentMediaRatingRow), CheckNames = true)]
public class ContentMediaRatingColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ContentTitle { get; set; }
    public string RatingName { get; set; }
    public short Score { get; set; }
    public string Username { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}