import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface TalukaRow {
    Id?: number;
    Title?: string;
    StateId?: number;
    DistrictId?: number;
    ShortName?: string;
    IsActive?: boolean;
    StateTitle?: string;
    DistrictTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class TalukaRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.Taluka';
    static readonly lookupKey = 'Masters.Taluka';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TalukaRow>('Masters.Taluka') }
    static async getLookupAsync() { return getLookupAsync<TalukaRow>('Masters.Taluka') }

    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<TalukaRow>();
}