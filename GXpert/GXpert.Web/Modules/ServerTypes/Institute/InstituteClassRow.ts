import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteClassRow {
    Id?: number;
    ClassId?: number;
    Division?: string;
    MediumId?: number;
    ClassTeacherId?: number;
    Title?: string;
    AcademicYearId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    InstituteId?: number;
    DepartmentId?: number;
    CourseId?: number;
    ClassTitle?: string;
    MediumTitle?: string;
    ClassTeacherPrn?: string;
    AcademicYearName?: string;
    InstituteName?: string;
    DepartmentTitle?: string;
    CourseTitle?: string;
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