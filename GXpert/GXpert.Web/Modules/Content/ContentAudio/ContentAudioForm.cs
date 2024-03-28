using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentAudio")]
[BasedOnRow(typeof(ContentAudioRow), CheckNames = true)]
public class ContentAudioForm
{
    public string MediaFile { get; set; }
    public string HlsFile { get; set; }
    public string FileKeyUrl { get; set; }
    public string Iv { get; set; }
    public int ContentId { get; set; }
    public int LanguageId { get; set; }
    public int UserId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}