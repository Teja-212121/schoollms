import { fieldsProxy } from "@serenity-is/corelib";
import { EHandRaiseStatus } from "../Web/Enums.EHandRaiseStatus";

export interface RaiseHandLiveSessionRow {
    Id?: number;
    LiveSessionlogId?: number;
    StudentId?: number;
    SessionTime?: string;
    HandRaiseStatus?: EHandRaiseStatus;
    PlayListId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class RaiseHandLiveSessionRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.RaiseHandLiveSession';
    static readonly deletePermission = 'Attendance:AttendanceManagement:Modify';
    static readonly insertPermission = 'Attendance:AttendanceManagement:Modify';
    static readonly readPermission = 'Attendance:AttendanceManagement:View';
    static readonly updatePermission = 'Attendance:AttendanceManagement:Modify';

    static readonly Fields = fieldsProxy<RaiseHandLiveSessionRow>();
}