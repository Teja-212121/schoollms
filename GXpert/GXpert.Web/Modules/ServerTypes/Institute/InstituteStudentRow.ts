import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteStudentRow {
    Id?: number;
    StudentId?: number;
    InstituteId?: number;
    InstituteDivisionId?: number;
    ClassId?: number;
    Division?: string;
    RollNumber?: string;
    Description?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    StartDate?: string;
    EndDate?: string;
    StudentPrn?: string;
    InstituteName?: string;
    ClassTitle?: string;
    AcademicYearName?: string;
    SemesterId?: number;
    Semester?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteStudentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'InstituteName';
    static readonly localTextPrefix = 'Institute.InstituteStudent';
    static readonly deletePermission = 'Institute:InstituteManagement:Modify';
    static readonly insertPermission = 'Institute:InstituteManagement:Modify';
    static readonly readPermission = 'Institute:InstituteManagement:View';
    static readonly updatePermission = 'Institute:InstituteManagement:Modify';

    static readonly Fields = fieldsProxy<InstituteStudentRow>();
}