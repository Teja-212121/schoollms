import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface StudentRow {
    Id?: number;
    Prn?: string;
    Name?: string;
    Email?: string;
    Mobile?: string;
    UserId?: number;
    Description?: string;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    Dob?: string;
    SchoolId?: number;
    IsActive?: boolean;
    Username?: string;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
    SchoolName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class StudentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Prn';
    static readonly localTextPrefix = 'Users.Student';
    static readonly lookupKey = 'Users.Student';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<StudentRow>('Users.Student') }
    static async getLookupAsync() { return getLookupAsync<StudentRow>('Users.Student') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<StudentRow>();
}