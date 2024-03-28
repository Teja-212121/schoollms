using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("Contents")]
[DisplayName("Content"), InstanceName("Content")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Content.Content")]
public sealed class ContentRow : LoggingRow<ContentRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("E Content Type"), NotNull]
    public short? EContentType { get => fields.EContentType[this]; set => fields.EContentType[this] = value; }

    [DisplayName("File Key Url"), Column("FileKeyURL"), NotNull]
    public string FileKeyUrl { get => fields.FileKeyUrl[this]; set => fields.FileKeyUrl[this] = value; }

    [DisplayName("Iv"), Column("IV"), Size(2000), NotNull]
    public string Iv { get => fields.Iv[this]; set => fields.Iv[this] = value; }

    [DisplayName("File Path"), NotNull]
    public string FilePath { get => fields.FilePath[this]; set => fields.FilePath[this] = value; }
    [DisplayName("Media File"), Size(1000), NotNull]
    public string MediaFile { get => fields.MediaFile[this]; set => fields.MediaFile[this] = value; }

    [DisplayName("Hls File"), Size(1000)]
    public string HlsFile { get => fields.HlsFile[this]; set => fields.HlsFile[this] = value; }
    [DisplayName("File Path Fall Back1"), NotNull]
    public string FilePathFallBack1 { get => fields.FilePathFallBack1[this]; set => fields.FilePathFallBack1[this] = value; }

    [DisplayName("File Path Fall Back2"), NotNull]
    public string FilePathFallBack2 { get => fields.FilePathFallBack2[this]; set => fields.FilePathFallBack2[this] = value; }

    [DisplayName("Media Info"), NotNull]
    public string MediaInfo { get => fields.MediaInfo[this]; set => fields.MediaInfo[this] = value; }

    [DisplayName("Thumb Nail"), NotNull,FileUploadEditor]
    public string ThumbNail { get => fields.ThumbNail[this]; set => fields.ThumbNail[this] = value; }

    [DisplayName("Poster"), Size(200), NotNull,FileUploadEditor]
    public string Poster { get => fields.Poster[this]; set => fields.Poster[this] = value; }

    [DisplayName("Length"), NotNull]
    public int? Length { get => fields.Length[this]; set => fields.Length[this] = value; }

    [DisplayName("Size"), NotNull]
    public int? Size { get => fields.Size[this]; set => fields.Size[this] = value; }

    [DisplayName("Number Of Pages"), NotNull]
    public int? NumberOfPages { get => fields.NumberOfPages[this]; set => fields.NumberOfPages[this] = value; }

    [DisplayName("Likes Count"), NotNull]
    public int? LikesCount { get => fields.LikesCount[this]; set => fields.LikesCount[this] = value; }

    [DisplayName("Dis Likes Count"), NotNull]
    public int? DisLikesCount { get => fields.DisLikesCount[this]; set => fields.DisLikesCount[this] = value; }

    [DisplayName("Hand Raise Count"), NotNull]
    public int? HandRaiseCount { get => fields.HandRaiseCount[this]; set => fields.HandRaiseCount[this] = value; }

    [DisplayName("Search Tags"), Size(500), NotNull]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("E Difficulty Level"), Column("eDifficultyLevel"), NotNull]
    public short? EDifficultyLevel { get => fields.EDifficultyLevel[this]; set => fields.EDifficultyLevel[this] = value; }

   
    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Allow Download"), NotNull]
    public bool? AllowDownload { get => fields.AllowDownload[this]; set => fields.AllowDownload[this] = value; }

    [DisplayName("Duration In Seconds"), NotNull]
    public int? DurationInSeconds { get => fields.DurationInSeconds[this]; set => fields.DurationInSeconds[this] = value; }

    [DisplayName("Enable Comments"), NotNull]
    public bool? EnableComments { get => fields.EnableComments[this]; set => fields.EnableComments[this] = value; }

    [DisplayName("Encoding Status"), Size(100)]
    public string EncodingStatus { get => fields.EncodingStatus[this]; set => fields.EncodingStatus[this] = value; }

    [DisplayName("Friendly Token"), Size(100)]
    public string FriendlyToken { get => fields.FriendlyToken[this]; set => fields.FriendlyToken[this] = value; }

    [DisplayName("E Content State"), NotNull]
    public short? EContentState { get => fields.EContentState[this]; set => fields.EContentState[this] = value; }

    [DisplayName("Views"), NotNull]
    public int? Views { get => fields.Views[this]; set => fields.Views[this] = value; }

    [DisplayName("Is Featured"), NotNull]
    public bool? IsFeatured { get => fields.IsFeatured[this]; set => fields.IsFeatured[this] = value; }

    [DisplayName("Is Reviewed"), NotNull]
    public bool? IsReviewed { get => fields.IsReviewed[this]; set => fields.IsReviewed[this] = value; }

    [DisplayName("Is Listed"), NotNull]
    public bool? IsListed { get => fields.IsListed[this]; set => fields.IsListed[this] = value; }

    [DisplayName("Thumbnail Time"),FileUploadEditor]
    public double? ThumbnailTime { get => fields.ThumbnailTime[this]; set => fields.ThumbnailTime[this] = value; }

    [DisplayName("Md5sum"), Size(100)]
    public string Md5sum { get => fields.Md5sum[this]; set => fields.Md5sum[this] = value; }

    [DisplayName("Is User Featured"), NotNull]
    public bool? IsUserFeatured { get => fields.IsUserFeatured[this]; set => fields.IsUserFeatured[this] = value; }

    [DisplayName("Size In Bytes"), NotNull]
    public long? SizeInBytes { get => fields.SizeInBytes[this]; set => fields.SizeInBytes[this] = value; }

    [DisplayName("Media Version"), NotNull]
    public short? MediaVersion { get => fields.MediaVersion[this]; set => fields.MediaVersion[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Download File Primary Url"), Size(500), NotNull]
    public string DownloadFilePrimaryUrl { get => fields.DownloadFilePrimaryUrl[this]; set => fields.DownloadFilePrimaryUrl[this] = value; }

    [DisplayName("Download File Fallback1 Url"), Size(500)]
    public string DownloadFileFallback1Url { get => fields.DownloadFileFallback1Url[this]; set => fields.DownloadFileFallback1Url[this] = value; }

    [DisplayName("Download File Fallback2 Url"), Size(500)]
    public string DownloadFileFallback2Url { get => fields.DownloadFileFallback2Url[this]; set => fields.DownloadFileFallback2Url[this] = value; }

    [DisplayName("M3u8 File Primary Url"), Size(500)]
    public string M3u8FilePrimaryUrl { get => fields.M3u8FilePrimaryUrl[this]; set => fields.M3u8FilePrimaryUrl[this] = value; }

    [DisplayName("M3u8 File Fallback1 Url"), Size(500)]
    public string M3u8FileFallback1Url { get => fields.M3u8FileFallback1Url[this]; set => fields.M3u8FileFallback1Url[this] = value; }

    [DisplayName("M3u8 File Fallback2 Url"), Size(500)]
    public string M3u8FileFallback2Url { get => fields.M3u8FileFallback2Url[this]; set => fields.M3u8FileFallback2Url[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField HlsFile;
        public StringField MediaFile;
        public StringField Description;
        public Int16Field EContentType;
        public StringField FileKeyUrl;
        public StringField Iv;
        public StringField FilePath;
        public StringField FilePathFallBack1;
        public StringField FilePathFallBack2;
        public StringField MediaInfo;
        public StringField ThumbNail;
        public StringField Poster;
        public Int32Field Length;
        public Int32Field Size;
        public Int32Field NumberOfPages;
        public Int32Field LikesCount;
        public Int32Field DisLikesCount;
        public Int32Field HandRaiseCount;
        public StringField SearchTags;
        public Int16Field EDifficultyLevel;
        
        public BooleanField IsActive;
        public BooleanField AllowDownload;
        public Int32Field DurationInSeconds;
        public BooleanField EnableComments;
        public StringField EncodingStatus;
        public StringField FriendlyToken;
        public Int16Field EContentState;
        public Int32Field Views;
        public BooleanField IsFeatured;
        public BooleanField IsReviewed;
        public BooleanField IsListed;
        public DoubleField ThumbnailTime;
        public StringField Md5sum;
        public BooleanField IsUserFeatured;
        public Int64Field SizeInBytes;
        public Int16Field MediaVersion;
        public Int32Field UserId;
        public StringField DownloadFilePrimaryUrl;
        public StringField DownloadFileFallback1Url;
        public StringField DownloadFileFallback2Url;
        public StringField M3u8FilePrimaryUrl;
        public StringField M3u8FileFallback1Url;
        public StringField M3u8FileFallback2Url;

        public StringField Username;
    }
}