using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.Content")]
[BasedOnRow(typeof(ContentRow), CheckNames = true)]
public class ContentForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short EContentType { get; set; }
    public string FileKeyUrl { get; set; }
    public string Iv { get; set; }
    public string FilePath { get; set; }
    public string FilePathFallBack1 { get; set; }
    public string FilePathFallBack2 { get; set; }
    public string MediaInfo { get; set; }
    public string ThumbNail { get; set; }
    public string Poster { get; set; }
    public int Length { get; set; }
    public int Size { get; set; }
    public int NumberOfPages { get; set; }
    public int LikesCount { get; set; }
    public int DisLikesCount { get; set; }
    public int HandRaiseCount { get; set; }
    public string SearchTags { get; set; }
    public short EDifficultyLevel { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}