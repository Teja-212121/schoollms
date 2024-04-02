import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EContentState } from "../GExpert/Enums.EContentState";
import { EContentType } from "../Web/Enums.EContentType";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";

export interface ContentRow {
    Id?: number;
    Title?: string;
    HlsFile?: string;
    MediaFile?: string;
    Description?: string;
    EContentType?: EContentType;
    FileKeyUrl?: string;
    Iv?: string;
    FilePath?: string;
    FilePathFallBack1?: string;
    FilePathFallBack2?: string;
    MediaInfo?: string;
    ThumbNail?: string;
    Poster?: string;
    Length?: number;
    Size?: number;
    NumberOfPages?: number;
    LikesCount?: number;
    DisLikesCount?: number;
    HandRaiseCount?: number;
    SearchTags?: string;
    EDifficultyLevel?: EDifficultyLevel;
    IsActive?: boolean;
    AllowDownload?: boolean;
    DurationInSeconds?: number;
    EnableComments?: boolean;
    EncodingStatus?: string;
    FriendlyToken?: string;
    EContentState?: EContentState;
    Views?: number;
    IsFeatured?: boolean;
    IsReviewed?: boolean;
    IsListed?: boolean;
    ThumbnailTime?: number;
    Md5sum?: string;
    IsUserFeatured?: boolean;
    SizeInBytes?: number;
    MediaVersion?: number;
    UserId?: number;
    DownloadFilePrimaryUrl?: string;
    DownloadFileFallback1Url?: string;
    DownloadFileFallback2Url?: string;
    M3u8FilePrimaryUrl?: string;
    M3u8FileFallback1Url?: string;
    M3u8FileFallback2Url?: string;
    Username?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Content.Content';
    static readonly lookupKey = 'Content.Content';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentRow>('Content.Content') }
    static async getLookupAsync() { return getLookupAsync<ContentRow>('Content.Content') }

    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentRow>();
}