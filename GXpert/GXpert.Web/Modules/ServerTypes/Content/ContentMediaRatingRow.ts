import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentMediaRatingRow {
    Id?: number;
    ContentId?: number;
    RatingId?: number;
    Score?: number;
    UserId?: number;
    IsActive?: number;
    ContentTitle?: string;
    RatingName?: string;
    Username?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentMediaRatingRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Content.ContentMediaRating';
    static readonly lookupKey = 'Content.ContentMediaRating';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentMediaRatingRow>('Content.ContentMediaRating') }
    static async getLookupAsync() { return getLookupAsync<ContentMediaRatingRow>('Content.ContentMediaRating') }

    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentMediaRatingRow>();
}