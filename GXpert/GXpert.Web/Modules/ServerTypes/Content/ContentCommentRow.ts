﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentCommentRow {
    Id?: number;
    CommentText?: string;
    CommentLeft?: number;
    CommentRight?: number;
    TreeId?: number;
    CommentLevel?: number;
    ParentId?: number;
    ContentId?: number;
    UserId?: number;
    IsActive?: number;
    ParentCommentText?: string;
    ContentTitle?: string;
    Username?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentCommentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CommentText';
    static readonly localTextPrefix = 'Content.ContentComment';
    static readonly lookupKey = 'Content.ContentComment';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentCommentRow>('Content.ContentComment') }
    static async getLookupAsync() { return getLookupAsync<ContentCommentRow>('Content.ContentComment') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentCommentRow>();
}