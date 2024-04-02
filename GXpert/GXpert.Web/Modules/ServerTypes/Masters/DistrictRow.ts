import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DistrictRow {
    Id?: number;
    Title?: string;
    StateId?: number;
    ShortName?: string;
    IsActive?: boolean;
    StateTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class DistrictRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.District';
    static readonly lookupKey = 'Masters.District';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DistrictRow>('Masters.District') }
    static async getLookupAsync() { return getLookupAsync<DistrictRow>('Masters.District') }

    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<DistrictRow>();
}