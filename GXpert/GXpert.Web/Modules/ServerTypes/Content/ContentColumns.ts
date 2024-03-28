import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EContentType } from "../Web/Enums.EContentType";
import { ContentRow } from "./ContentRow";

export interface ContentColumns {
    Id: Column<ContentRow>;
    Title: Column<ContentRow>;
    Description: Column<ContentRow>;
    EContentType: Column<ContentRow>;
    FileKeyUrl: Column<ContentRow>;
    Iv: Column<ContentRow>;
    MediaFile: Column<ContentRow>;
    HlsFile: Column<ContentRow>;
    FilePath: Column<ContentRow>;
    FilePathFallBack1: Column<ContentRow>;
    FilePathFallBack2: Column<ContentRow>;
    MediaInfo: Column<ContentRow>;
    ThumbNail: Column<ContentRow>;
    Poster: Column<ContentRow>;
    Length: Column<ContentRow>;
    Size: Column<ContentRow>;
    NumberOfPages: Column<ContentRow>;
    LikesCount: Column<ContentRow>;
    DisLikesCount: Column<ContentRow>;
    HandRaiseCount: Column<ContentRow>;
    SearchTags: Column<ContentRow>;
    EDifficultyLevel: Column<ContentRow>;
    AllowDownload: Column<ContentRow>;
    DurationInSeconds: Column<ContentRow>;
    EnableComments: Column<ContentRow>;
    EncodingStatus: Column<ContentRow>;
    FriendlyToken: Column<ContentRow>;
    EContentState: Column<ContentRow>;
    Views: Column<ContentRow>;
    IsFeatured: Column<ContentRow>;
    IsReviewed: Column<ContentRow>;
    IsListed: Column<ContentRow>;
    ThumbnailTime: Column<ContentRow>;
    Md5sum: Column<ContentRow>;
    IsUserFeatured: Column<ContentRow>;
    SizeInBytes: Column<ContentRow>;
    MediaVersion: Column<ContentRow>;
    Username: Column<ContentRow>;
    DownloadFilePrimaryUrl: Column<ContentRow>;
    DownloadFileFallback1Url: Column<ContentRow>;
    DownloadFileFallback2Url: Column<ContentRow>;
    M3u8FilePrimaryUrl: Column<ContentRow>;
    M3u8FileFallback1Url: Column<ContentRow>;
    M3u8FileFallback2Url: Column<ContentRow>;
}

export class ContentColumns extends ColumnsBase<ContentRow> {
    static readonly columnsKey = 'Content.Content';
    static readonly Fields = fieldsProxy<ContentColumns>();
}

[EContentType]; // referenced types