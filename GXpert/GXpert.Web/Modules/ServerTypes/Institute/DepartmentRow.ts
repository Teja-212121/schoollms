import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DepartmentRow {
    Id?: number;
    Title?: string;
    InstituteId?: number;
    HODId?: number;
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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DepartmentRow>();
}