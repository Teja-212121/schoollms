﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface PlayListContentRow {
    Id?: number;
    PlayListId?: number;
    ContentId?: number;
    ExamId?: number;
    LiveSessionId?: number;
    AssignmentId?: number;
    ModuleId?: number;
    SortOrder?: number;
    EPublishStatus?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    PlayListTitle?: string;
    ContentTitle?: string;
    ExamTitle?: string;
    LiveSessionMeetingId?: string;
    AssignmentTitle?: string;
    ModuleTitle?: string;
}

export abstract class PlayListContentRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Playlist.PlayListContent';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PlayListContentRow>();
}