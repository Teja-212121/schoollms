import { fieldsProxy } from "@serenity-is/corelib";
import { ESchoolTimeTableType } from "../Web/Enums.ESchoolTimeTableType";

export interface SchoolTimeTableRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    PeriodIndex?: number;
    SchoolClassId?: number;
    TeacherId?: number;
    EType?: ESchoolTimeTableType;
    IsActive?: boolean;
    SchoolClassDivision?: string;
    TeacherPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
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