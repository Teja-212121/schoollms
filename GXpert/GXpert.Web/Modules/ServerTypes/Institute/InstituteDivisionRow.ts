import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface InstituteDivisionRow {
    Id?: number;
    ClassId?: number;
    Division?: string;
    ClassTeacherId?: number;
    Title?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    InstituteId?: number;
    DepartmentId?: number;
    CourseId?: number;
    SemesterId?: number;
    ClassTitle?: string;
    ClassTeacherPrn?: string;
    AcademicYearName?: string;
    InstituteName?: string;
    DepartmentTitle?: string;
    CourseTitle?: string;
    SemesterTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteDivisionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Division';
    static readonly localTextPrefix = 'Institute.InstituteDivision';
    static readonly lookupKey = 'Institute.InstituteDivision';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<InstituteDivisionRow>('Institute.InstituteDivision') }
    static async getLookupAsync() { return getLookupAsync<InstituteDivisionRow>('Institute.InstituteDivision') }

    static readonly deletePermission = 'Institute:InstituteManagement:Modify';
    static readonly insertPermission = 'Institute:InstituteManagement:Modify';
    static readonly readPermission = 'Institute:InstituteManagement:View';
    static readonly updatePermission = 'Institute:InstituteManagement:Modify';

    static readonly Fields = fieldsProxy<InstituteDivisionRow>();
}