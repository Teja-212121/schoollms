import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EAttendanceStatus } from "../Web/Enums.EAttendanceStatus";

export interface StudentClassAttendanceRow {
    Id?: number;
    InstituteTimeTableId?: number;
    StudentId?: number;
    AttendanceStatus?: EAttendanceStatus;
    IsActive?: number;
    StudentPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class StudentClassAttendanceRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.StudentClassAttendance';
    static readonly lookupKey = 'Attendance.Student Class Attendance';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<StudentClassAttendanceRow>('Attendance.Student Class Attendance') }
    static async getLookupAsync() { return getLookupAsync<StudentClassAttendanceRow>('Attendance.Student Class Attendance') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<StudentClassAttendanceRow>();
}