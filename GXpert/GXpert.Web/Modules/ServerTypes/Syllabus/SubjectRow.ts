import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SubjectRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    ClassId?: number;
    CourseId?: number;
    CourseName?: string;
    SemesterId?: number;
    SemesterName?: string;
    Weightage?: number;
    Thumbnail?: string;
    IsActive?: boolean;
    ClassTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SubjectRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Subject';
    static readonly lookupKey = 'Syllabus.Subject';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SubjectRow>('Syllabus.Subject') }
    static async getLookupAsync() { return getLookupAsync<SubjectRow>('Syllabus.Subject') }

    static readonly deletePermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly insertPermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly readPermission = 'Syllabus:SyllabusManagement:View';
    static readonly updatePermission = 'Syllabus:SyllabusManagement:Modify';

    static readonly Fields = fieldsProxy<SubjectRow>();
}