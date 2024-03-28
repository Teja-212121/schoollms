import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentCategoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsGlobal?: boolean;
    MediaCount?: number;
    Thumbnail?: string;
    ListingThumbnail?: string;
    IsActive?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentCategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentCategory';
    static readonly lookupKey = 'Content.ContentCategory';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentCategoryRow>('Content.ContentCategory') }
    static async getLookupAsync() { return getLookupAsync<ContentCategoryRow>('Content.ContentCategory') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentCategoryRow>();
}