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
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteTeacherRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Description';
    static readonly localTextPrefix = 'Institute.InstituteTeacher';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteTeacherRow>();
}