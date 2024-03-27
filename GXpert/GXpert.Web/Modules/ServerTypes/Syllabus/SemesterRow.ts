import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SemesterRow {
    Id?: number;
    Title?: string;
    CourseId?: number;
    ClassId?: number;
    Description?: string;
    SortOrder?: number;
    IsActive?: boolean;
    CourseTitle?: string;
    ClassTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SemesterRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Semester';
    static readonly lookupKey = 'Syllabus.Semester';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SemesterRow>('Syllabus.Semester') }
    static async getLookupAsync() { return getLookupAsync<SemesterRow>('Syllabus.Semester') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SemesterRow>();
}