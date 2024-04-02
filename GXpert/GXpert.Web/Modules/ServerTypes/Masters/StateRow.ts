import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface StateRow {
    Id?: number;
    Title?: string;
    ShortName?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class StateRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.State';
    static readonly lookupKey = 'Masters.State';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<StateRow>('Masters.State') }
    static async getLookupAsync() { return getLookupAsync<StateRow>('Masters.State') }

    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<StateRow>();
}