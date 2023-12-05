import { fieldsProxy } from "@serenity-is/corelib";

export interface RaiseHandLiveSessionRow {
    Id?: number;
    LiveSessionlogId?: number;
    StudentId?: number;
    SessionTime?: string;
    HandRaiseStatus?: number;
    PlayListId?: number;
    ActivationId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
}

export abstract class RaiseHandLiveSessionRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.RaiseHandLiveSession';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<RaiseHandLiveSessionRow>();
}