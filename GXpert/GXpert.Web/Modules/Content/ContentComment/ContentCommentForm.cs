using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentComment")]
[BasedOnRow(typeof(ContentCommentRow), CheckNames = true)]
public class ContentCommentForm
{
    public string CommentText { get; set; }
    public int CommentLeft { get; set; }
    public int CommentRight { get; set; }
    public int TreeId { get; set; }
    public int CommentLevel { get; set; }
    public int ParentId { get; set; }
    public int ContentId { get; set; }
    public int UserId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}