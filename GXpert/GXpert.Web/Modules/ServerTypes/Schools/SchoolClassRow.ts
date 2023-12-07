import { fieldsProxy } from "@serenity-is/corelib";

export interface SchoolClassRow {
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
    ClassTitle?: string;
    MediumTitle?: string;
    ClassTeacherPrn?: string;
    AcademicYearName?: string;
}

export abstract class SchoolClassRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Division';
    static readonly localTextPrefix = 'Schools.SchoolClass';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SchoolClassRow>();
}