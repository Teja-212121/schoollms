import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface StudentRow {
    Id?: number;
    Prn?: string;
    Name?: string;
    Email?: string;
    Mobile?: string;
    UserId?: number;
    InstituteId?: number;
    DepartmentId?: number;
    BranchId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    CurrentAcademicYearId?: number;
    InstituteName?: string;
    DivisionId?: number;
    InstituteDivision?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    Gender?: string;
    AddressLine1?: string;
    AddressLine2?: string;
    SemesterTitle?: string;
    AcademicYearName?: string;
    Description?: string;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    Dob?: string;
    DepartmentTitle?: string;
    BranchTitle?: string;
    IsActive?: boolean;
    Username?: string;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
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