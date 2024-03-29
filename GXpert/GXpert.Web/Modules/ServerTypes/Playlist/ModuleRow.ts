import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ModuleRow {
    Id?: number;
    Title?: string;
    Description?: string;
    ParentId?: number;
    SortOrder?: number;
    IsActive?: boolean;
    ParentTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ModuleRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Playlist.Module';
    static readonly lookupKey = 'Playlist.Module';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ModuleRow>('Playlist.Module') }
    static async getLookupAsync() { return getLookupAsync<ModuleRow>('Playlist.Module') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ModuleRow>();
}