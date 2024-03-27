import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteClassRow {
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
    Semester?: string;
    ClassTitle?: string;
    ClassTeacherPrn?: string;
    AcademicYearName?: string;
    InstituteName?: string;
    DepartmentTitle?: string;
    CourseTitle?: string;
    SemesterId?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteClassRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Division';
    static readonly localTextPrefix = 'Institute.InstituteClass';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteClassRow>();
}