import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentCategoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsGlobal?: boolean;
    MediaCount?: number;
    Thumbnail?: string;
    ListingThumbnail?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
}

export abstract class ContentCategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentCategory';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentCategoryRow>();
}