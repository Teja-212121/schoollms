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
   
}