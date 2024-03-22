import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PrincipalRow {
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

export abstract class PrincipalRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Users.Principal';
    static readonly lookupKey = 'Users.Principal';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PrincipalRow>('Users.Principal') }
    static async getLookupAsync() { return getLookupAsync<PrincipalRow>('Users.Principal') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PrincipalRow>();
}