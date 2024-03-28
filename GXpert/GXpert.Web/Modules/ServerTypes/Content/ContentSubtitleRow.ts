import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentSubtitleRow {
    Id?: number;
    SubtitleFile?: string;
    ContentId?: number;
    LanguageId?: number;
    UserId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    ContentTitle?: string;
    LanguageName?: string;
    Username?: string;
}

export abstract class ContentSubtitleRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SubtitleFile';
    static readonly localTextPrefix = 'Content.ContentSubtitle';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentSubtitleRow>();
}