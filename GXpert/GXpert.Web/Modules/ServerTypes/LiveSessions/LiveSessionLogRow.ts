import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface LiveSessionLogRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    TeacherId?: number;
    ClassId?: number;
    SubjectId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    TeacherPrn?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
}

export abstract class LiveSessionLogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'LiveSessions.LiveSessionLog';
    static readonly lookupKey = 'LiveSessions.LiveSessionLog';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<LiveSessionLogRow>('LiveSessions.LiveSessionLog') }
    static async getLookupAsync() { return getLookupAsync<LiveSessionLogRow>('LiveSessions.LiveSessionLog') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<LiveSessionLogRow>();
}