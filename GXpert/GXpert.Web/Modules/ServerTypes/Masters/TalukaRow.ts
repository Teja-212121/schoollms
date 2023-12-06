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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TalukaRow>();
}