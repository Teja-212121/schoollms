import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentRatingRow {
    Id?: number;
    Name?: string;
    Description?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
}

export abstract class ContentRatingRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentRating';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentRatingRow>();
}