import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentAudioRow {
    Id?: number;
    MediaFile?: string;
    HlsFile?: string;
    FileKeyUrl?: string;
    Iv?: string;
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

export abstract class ContentAudioRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'MediaFile';
    static readonly localTextPrefix = 'Content.ContentAudio';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentAudioRow>();
}