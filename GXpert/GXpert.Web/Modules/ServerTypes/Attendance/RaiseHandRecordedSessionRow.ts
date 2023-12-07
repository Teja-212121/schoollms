import { fieldsProxy } from "@serenity-is/corelib";

export interface RaiseHandRecordedSessionRow {
    Id?: number;
    ContentId?: number;
    StudentId?: number;
    PlayListId?: number;
    PlayListContentId?: number;
    ActivationId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    StudentPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
}

export abstract class RaiseHandRecordedSessionRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.RaiseHandRecordedSession';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<RaiseHandRecordedSessionRow>();
}