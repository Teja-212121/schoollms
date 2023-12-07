using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.Content")]
[BasedOnRow(typeof(ContentRow), CheckNames = true)]
public class ContentForm
{
    [HalfWidth]
    public string Title { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    [HalfWidth]
    public short EContentType { get; set; }
    public string FileKeyUrl { get; set; }
    [HalfWidth]
    public string Iv { get; set; }
    public string FilePath { get; set; }
    public string FilePathFallBack1 { get; set; }
    public string FilePathFallBack2 { get; set; }
    public string MediaInfo { get; set; }
    [HalfWidth]
    public string ThumbNail { get; set; }
    [HalfWidth]
    public string Poster { get; set; }
    [HalfWidth]
    public int Length { get; set; }
    [HalfWidth]
    public int Size { get; set; }
    [HalfWidth]
    public int NumberOfPages { get; set; }
    [HalfWidth]
    public int LikesCount { get; set; }
    [HalfWidth]
    public int DisLikesCount { get; set; }
    [HalfWidth]
    public int HandRaiseCount { get; set; }
    [HalfWidth]
    public string SearchTags { get; set; }
    [HalfWidth]
    public short EDifficultyLevel { get; set; }
}