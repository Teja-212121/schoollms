import { fieldsProxy } from "@serenity-is/corelib";

export interface ModuleRow {
    Id?: number;
    Title?: string;
    Description?: string;
    ParentId?: number;
    SortOrder?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ParentTitle?: string;
}

export abstract class ModuleRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Playlist.Module';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ModuleRow>();
}