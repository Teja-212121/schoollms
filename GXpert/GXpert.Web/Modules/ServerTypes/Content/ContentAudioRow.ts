import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentAudioRow {
    Id?: number;
    MediaFile?: string;
    HlsFile?: string;
    FileKeyUrl?: string;
    Iv?: string;
    ContentId?: number;
    LanguageId?: number;
    UserId?: number;
    IsActive?: number;
    ContentTitle?: string;
    LanguageName?: string;
    Username?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentAudioRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'MediaFile';
    static readonly localTextPrefix = 'Content.ContentAudio';
    static readonly lookupKey = 'Content.ContentAudio';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentAudioRow>('Content.ContentAudio') }
    static async getLookupAsync() { return getLookupAsync<ContentAudioRow>('Content.ContentAudio') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentAudioRow>();
}