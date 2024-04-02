import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentRatingRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsActive?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentRatingRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentRating';
    static readonly lookupKey = 'Content.ContentRating';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentRatingRow>('Content.ContentRating') }
    static async getLookupAsync() { return getLookupAsync<ContentRatingRow>('Content.ContentRating') }

    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentRatingRow>();
}