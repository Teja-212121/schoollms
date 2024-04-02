import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface BranchRow {
    Id?: number;
    Title?: string;
    InstituteId?: number;
    DepartmentId?: number;
    Description?: string;
    BranchCode?: number;
    IsActive?: boolean;
    InstituteName?: string;
    DepartmentTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class BranchRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Institute.Branch';
    static readonly lookupKey = 'Institute.Branch';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<BranchRow>('Institute.Branch') }
    static async getLookupAsync() { return getLookupAsync<BranchRow>('Institute.Branch') }

    static readonly deletePermission = 'Institute:InstituteManagement:Modify';
    static readonly insertPermission = 'Institute:InstituteManagement:Modify';
    static readonly readPermission = 'Institute:InstituteManagement:View';
    static readonly updatePermission = 'Institute:InstituteManagement:Modify';

    static readonly Fields = fieldsProxy<BranchRow>();
}