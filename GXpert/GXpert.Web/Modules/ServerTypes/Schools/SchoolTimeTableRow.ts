import { fieldsProxy } from "@serenity-is/corelib";

export interface SchoolTimeTableRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    PeriodIndex?: number;
    SchoolClassId?: number;
    TeacherId?: number;
    EType?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    SchoolClassDivision?: string;
    TeacherPrn?: string;
}

export abstract class SchoolTimeTableRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EType';
    static readonly localTextPrefix = 'Schools.SchoolTimeTable';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SchoolTimeTableRow>();
}