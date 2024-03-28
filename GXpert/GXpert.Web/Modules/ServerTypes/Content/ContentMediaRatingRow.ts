import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentMediaRatingRow {
    Id?: number;
    ContentId?: number;
    RatingId?: number;
    Score?: number;
    UserId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    ContentTitle?: string;
    RatingName?: string;
    Username?: string;
}

export abstract class ContentMediaRatingRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Content.ContentMediaRating';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentMediaRatingRow>();
}