import { fieldsProxy } from "@serenity-is/corelib";

export interface PollResponseRow {
    Id?: number;
    PollId?: number;
    StudentId?: number;
    Response?: string;
    ResponseTimeInSeconds?: number;
    Score?: number;
    LiveSessionLogId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    PollQuestion?: string;
    StudentPrn?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PollResponseRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Response';
    static readonly localTextPrefix = 'Attendance.PollResponse';
    static readonly deletePermission = 'Attendance:AttendanceManagement:Modify';
    static readonly insertPermission = 'Attendance:AttendanceManagement:Modify';
    static readonly readPermission = 'Attendance:AttendanceManagement:View';
    static readonly updatePermission = 'Attendance:AttendanceManagement:Modify';

    static readonly Fields = fieldsProxy<PollResponseRow>();
}