import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DepartmentRow {
    Id?: number;
    Title?: string;
    InstituteId?: number;
    HodId?: number;
    Description?: string;
    IsActive?: boolean;
    InstituteName?: string;
    HODName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class DepartmentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Institute.Department';
    static readonly lookupKey = 'Institute.Department';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DepartmentRow>('Institute.Department') }
    static async getLookupAsync() { return getLookupAsync<DepartmentRow>('Institute.Department') }

    static readonly deletePermission = 'Institute:InstituteManagement:Modify';
    static readonly insertPermission = 'Institute:InstituteManagement:Modify';
    static readonly readPermission = 'Institute:InstituteManagement:View';
    static readonly updatePermission = 'Institute:InstituteManagement:Modify';

    static readonly Fields = fieldsProxy<DepartmentRow>();
}