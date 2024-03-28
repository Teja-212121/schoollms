using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentComment")]
[BasedOnRow(typeof(ContentCommentRow), CheckNames = true)]
public class ContentCommentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string CommentText { get; set; }
    public int CommentLeft { get; set; }
    public int CommentRight { get; set; }
    public int TreeId { get; set; }
    public int CommentLevel { get; set; }
    public string ParentCommentText { get; set; }
    public string ContentTitle { get; set; }
    public string Username { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}