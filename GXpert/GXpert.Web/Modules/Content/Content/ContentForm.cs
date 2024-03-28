using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.Content")]
[BasedOnRow(typeof(ContentRow), CheckNames = true)]
public class ContentForm
{
    [Category("General")]
    [HalfWidth]
    public string Title { get; set; }
    [HalfWidth]
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    [HalfWidth]
    public short EContentType { get; set; }
    [HalfWidth]
    public short EContentState { get; set; }
    [HalfWidth]
    public short EDifficultyLevel { get; set; }
    [HalfWidth]
    public short MediaVersion { get; set; }
    [HalfWidth]
    public string EncodingStatus { get; set; }
    [HalfWidth]
    public string MediaFile { get; set; }
    [HalfWidth]
    public string HlsFile { get; set; }
    [HalfWidth]
    public string FileKeyUrl { get; set; }
    [HalfWidth]
    public string Iv { get; set; }
    [HalfWidth]
    public string FriendlyToken { get; set; }
    [HalfWidth]
    public string MediaInfo { get; set; }
    [HalfWidth]
    public long SizeInBytes { get; set; }
    [HalfWidth]
    public int DurationInSeconds { get; set; }
    [HalfWidth]
    public string SearchTags { get; set; }
    public string FilePath { get; set; }
    public string FilePathFallBack1 { get; set; }
    public string FilePathFallBack2 { get; set; }
    public string DownloadFilePrimaryUrl { get; set; }
    public string DownloadFileFallback1Url { get; set; }
    public string DownloadFileFallback2Url { get; set; }
    public string M3u8FilePrimaryUrl { get; set; }
    public string M3u8FileFallback1Url { get; set; }
    public string M3u8FileFallback2Url { get; set; }
    [Category("Attributes")]
    [HalfWidth]
   
    public bool AllowDownload { get; set; }
    [HalfWidth]
    public bool EnableComments { get; set; }
    [HalfWidth]
    public int Views { get; set; }
    [HalfWidth]
    public bool IsFeatured { get; set; }
    [HalfWidth]
    public bool IsReviewed { get; set; }
    [HalfWidth]
    public bool IsListed { get; set; }
    [HalfWidth]
    public string Md5sum { get; set; }
    [HalfWidth]
    public bool IsUserFeatured { get; set; }
    [Category("ThumbNails")]
    [HalfWidth]
    public string ThumbNail { get; set; }
    [HalfWidth]
    public double ThumbnailTime { get; set; }
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
    public int UserId { get; set; }
   
}