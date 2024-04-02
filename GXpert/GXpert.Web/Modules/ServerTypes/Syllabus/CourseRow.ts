import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface CourseRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    Thumbnail?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class CourseRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Course';
    static readonly lookupKey = 'Syllabus.Course';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CourseRow>('Syllabus.Course') }
    static async getLookupAsync() { return getLookupAsync<CourseRow>('Syllabus.Course') }

    static readonly deletePermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly insertPermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly readPermission = 'Syllabus:SyllabusManagement:View';
    static readonly updatePermission = 'Syllabus:SyllabusManagement:Modify';

    static readonly Fields = fieldsProxy<CourseRow>();
}