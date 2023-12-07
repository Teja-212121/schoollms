import { fieldsProxy } from "@serenity-is/corelib";

export interface SchoolStudentRow {
    Id?: number;
    StudentId?: number;
    SchoolId?: number;
    ClassId?: number;
    Division?: string;
    RollNumber?: string;
    Description?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    SchoolName?: string;
    ClassTitle?: string;
    AcademicYearName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SchoolStudentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Division';
    static readonly localTextPrefix = 'Schools.SchoolStudent';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SchoolStudentRow>();
}