import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EExamStatus } from "../Web/Enums.EExamStatus";
import { EPlayListContentType } from "../Web/Enums.EPlayListContentType";

export interface PlayListContentRow {
    Id?: number;
    EContentType?: EPlayListContentType;
    PlayListId?: number;
    ContentId?: number;
    ExamId?: number;
    LiveSessionId?: number;
    AssignmentId?: number;
    ModuleId?: number;
    SortOrder?: number;
    EPublishStatus?: EExamStatus;
    IsActive?: boolean;
    PlayListTitle?: string;
    ContentTitle?: string;
    ExamTitle?: string;
    LiveSessionMeetingId?: string;
    AssignmentTitle?: string;
    ModuleTitle?: string;
    RowIds?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PlayListContentRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Playlist.PlayListContent';
    static readonly lookupKey = 'Playlist.PlayListContent';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PlayListContentRow>('Playlist.PlayListContent') }
    static async getLookupAsync() { return getLookupAsync<PlayListContentRow>('Playlist.PlayListContent') }

    static readonly deletePermission = 'Playlist:PlaylistManagement:Modify';
    static readonly insertPermission = 'Playlist:PlaylistManagement:Modify';
    static readonly readPermission = 'Playlist:PlaylistManagement:View';
    static readonly updatePermission = 'Playlist:PlaylistManagement:Modify';

    static readonly Fields = fieldsProxy<PlayListContentRow>();
}