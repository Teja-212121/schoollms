using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentSubtitle")]
[BasedOnRow(typeof(ContentSubtitleRow), CheckNames = true)]
public class ContentSubtitleForm
{
    public string SubtitleFile { get; set; }
    public int ContentId { get; set; }
    public int LanguageId { get; set; }
    public int UserId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}