using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentAudio")]
[BasedOnRow(typeof(ContentAudioRow), CheckNames = true)]
public class ContentAudioColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string MediaFile { get; set; }
    public string HlsFile { get; set; }
    public string FileKeyUrl { get; set; }
    public string Iv { get; set; }
    public string ContentTitle { get; set; }
    public string LanguageName { get; set; }
    public string Username { get; set; }
   
}