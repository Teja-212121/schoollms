import { fieldsProxy } from "@serenity-is/corelib";

export interface RaiseHandRecordedSessionRow {
    Id?: number;
    ContentId?: number;
    StudentId?: number;
    PlayListId?: number;
    PlayListContentId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    StudentPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class RaiseHandRecordedSessionRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.RaiseHandRecordedSession';
    static readonly deletePermission = 'Attendance:AttendanceManagement:Modify';
    static readonly insertPermission = 'Attendance:AttendanceManagement:Modify';
    static readonly readPermission = 'Attendance:AttendanceManagement:View';
    static readonly updatePermission = 'Attendance:AttendanceManagement:Modify';

    static readonly Fields = fieldsProxy<RaiseHandRecordedSessionRow>();
}