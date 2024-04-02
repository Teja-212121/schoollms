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

    static readonly deletePermission = 'Attendance:AttendanceManagement:Modify';
    static readonly insertPermission = 'Attendance:AttendanceManagement:Modify';
    static readonly readPermission = 'Attendance:AttendanceManagement:View';
    static readonly updatePermission = 'Attendance:AttendanceManagement:Modify';

    static readonly Fields = fieldsProxy<StudentClassAttendanceRow>();
}