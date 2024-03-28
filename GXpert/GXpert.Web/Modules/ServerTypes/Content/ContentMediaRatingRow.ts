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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentMediaRatingRow>();
}