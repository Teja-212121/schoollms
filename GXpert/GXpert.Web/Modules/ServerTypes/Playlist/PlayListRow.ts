﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PlayListRow {
    Id?: number;
    Title?: string;
    Description?: string;
    ClassId?: number;
    SubjectId?: number;
    TeacherId?: number;
    PlayListFilePath?: string;
    PlayListVersion?: number;
    IsActive?: boolean;
    CourseTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TeacherPrn?: string;
    CourseId?: number;
    SemesterId?: number;
    SemesterName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PlayListRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Playlist.PlayList';
    static readonly lookupKey = 'Playlist.PlayList';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PlayListRow>('Playlist.PlayList') }
    static async getLookupAsync() { return getLookupAsync<PlayListRow>('Playlist.PlayList') }

    static readonly deletePermission = 'Playlist:PlaylistManagement:Modify';
    static readonly insertPermission = 'Playlist:PlaylistManagement:Modify';
    static readonly readPermission = 'Playlist:PlaylistManagement:View';
    static readonly updatePermission = 'Playlist:PlaylistManagement:Modify';

    static readonly Fields = fieldsProxy<PlayListRow>();
}