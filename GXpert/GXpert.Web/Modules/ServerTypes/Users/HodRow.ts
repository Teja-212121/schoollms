import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface HodRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Mobile?: string;
    UserId?: number;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    Dob?: string;
    InstituteId?: number;
    IsActive?: boolean;
    Username?: string;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
    InstituteName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class HodRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Users.Hod';
    static readonly lookupKey = 'Users.Hod';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<HodRow>('Users.Hod') }
    static async getLookupAsync() { return getLookupAsync<HodRow>('Users.Hod') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<HodRow>();
}