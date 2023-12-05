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
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    PollQuestion?: string;
    StudentPrn?: string;
    ActivationDeviceId?: string;
}

export abstract class PollResponseRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Response';
    static readonly localTextPrefix = 'Attendance.PollResponse';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PollResponseRow>();
}