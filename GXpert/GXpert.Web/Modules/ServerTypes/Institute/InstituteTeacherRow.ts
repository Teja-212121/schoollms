import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteTeacherRow {
    Id?: number;
    TeacherId?: number;
    InstituteId?: number;
    ClassId?: number;
    SubjectId?: number;
    Description?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    TeacherPrn?: string;
    InstituteName?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    AcademicYearName?: string;
    Semester?: string;
    SemesterId?: number;
    InstituteDivisionId?: number;
    InstituteDivision?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteTeacherRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Description';
    static readonly localTextPrefix = 'Institute.InstituteTeacher';
    static readonly deletePermission = 'Institute:InstituteManagement:Modify';
    static readonly insertPermission = 'Institute:InstituteManagement:Modify';
    static readonly readPermission = 'Institute:InstituteManagement:View';
    static readonly updatePermission = 'Institute:InstituteManagement:Modify';

    static readonly Fields = fieldsProxy<InstituteTeacherRow>();
}