import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentSubtitleRow {
    Id?: number;
    SubtitleFile?: string;
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

export abstract class ContentSubtitleRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SubtitleFile';
    static readonly localTextPrefix = 'Content.ContentSubtitle';
    static readonly lookupKey = 'Content.ContentSubtitle';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentSubtitleRow>('Content.ContentSubtitle') }
    static async getLookupAsync() { return getLookupAsync<ContentSubtitleRow>('Content.ContentSubtitle') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentSubtitleRow>();
}