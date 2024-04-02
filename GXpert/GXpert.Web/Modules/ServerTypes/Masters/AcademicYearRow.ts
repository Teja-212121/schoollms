import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AcademicYearRow {
    Id?: number;
    Name?: string;
    Description?: string;
    StartDate?: string;
    EndDate?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AcademicYearRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Masters.AcademicYear';
    static readonly lookupKey = 'Masters.AcademicYear';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AcademicYearRow>('Masters.AcademicYear') }
    static async getLookupAsync() { return getLookupAsync<AcademicYearRow>('Masters.AcademicYear') }

    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<AcademicYearRow>();
}