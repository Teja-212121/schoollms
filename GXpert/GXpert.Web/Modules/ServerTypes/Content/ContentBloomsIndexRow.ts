import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentBloomsIndexRow {
    Id?: number;
    ContentId?: number;
    BloomsIndex?: number;
    Weightage?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    BloomsIndexCoginitiveSkill?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentBloomsIndexRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Content.ContentBloomsIndex';
    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentBloomsIndexRow>();
}