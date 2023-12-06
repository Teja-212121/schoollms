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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentBloomsIndexRow>();
}