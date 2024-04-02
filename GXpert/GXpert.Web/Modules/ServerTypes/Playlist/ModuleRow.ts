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

    static readonly deletePermission = 'Playlist:PlaylistManagement:Modify';
    static readonly insertPermission = 'Playlist:PlaylistManagement:Modify';
    static readonly readPermission = 'Playlist:PlaylistManagement:View';
    static readonly updatePermission = 'Playlist:PlaylistManagement:Modify';

    static readonly Fields = fieldsProxy<ModuleRow>();
}