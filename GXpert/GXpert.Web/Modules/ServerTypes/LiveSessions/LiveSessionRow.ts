import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { ELiveProvider } from "../Web/Enums.ELiveProvider";

export interface LiveSessionRow {
    Id?: number;
    MeetingId?: string;
    LiveProvider?: ELiveProvider;
    Password?: string;
    Secret?: string;
    LiveAdditionalInfo?: string;
    SearchTags?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class LiveSessionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'MeetingId';
    static readonly localTextPrefix = 'LiveSessions.LiveSession';
    static readonly lookupKey = 'LiveSessions.LiveSession';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<LiveSessionRow>('LiveSessions.LiveSession') }
    static async getLookupAsync() { return getLookupAsync<LiveSessionRow>('LiveSessions.LiveSession') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<LiveSessionRow>();
}