import { fieldsProxy } from "@serenity-is/corelib";
import { EInstituteTimeTableType } from "../Web/Enums.EInstituteTimeTableType";

export interface InstituteTimeTableRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    PeriodIndex?: number;
    InstituteDivisionId?: number;
    TeacherId?: number;
    EType?: EInstituteTimeTableType;
    IsActive?: boolean;
    ClassRoomNo?: number;
    InstituteClassDivision?: string;
    TeacherPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
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