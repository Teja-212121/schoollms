import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ClassRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    Weightage?: number;
    Thumbnail?: string;
    CourseId?: number;
    CourseName?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ClassRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Class';
    static readonly lookupKey = 'Syllabus.Class';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ClassRow>('Syllabus.Class') }
    static async getLookupAsync() { return getLookupAsync<ClassRow>('Syllabus.Class') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ClassRow>();
}