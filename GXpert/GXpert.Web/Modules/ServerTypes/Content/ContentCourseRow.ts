import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentCourseRow {
    Id?: number;
    ContentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    UserId?: number;
    IsActive?: number;
    ContentTitle?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    Username?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentCourseRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Content.ContentCourse';
    static readonly lookupKey = 'Content.ContentCourse';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentCourseRow>('Content.ContentCourse') }
    static async getLookupAsync() { return getLookupAsync<ContentCourseRow>('Content.ContentCourse') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentCourseRow>();
}