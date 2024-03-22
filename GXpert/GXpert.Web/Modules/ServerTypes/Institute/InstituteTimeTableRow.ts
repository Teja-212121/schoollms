import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteTimeTableRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    PeriodIndex?: number;
    SchoolClassId?: number;
    TeacherId?: number;
    EType?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    SchoolClassDivision?: string;
    TeacherPrn?: string;
}

export abstract class InstituteTimeTableRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Institute.InstituteTimeTable';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteTimeTableRow>();
}