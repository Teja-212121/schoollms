import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface TopicRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    ClassId?: number;
    CourseId?: number;
    CourseName?: string;
    SemesterId?: number;
    SemesterName?: string;
    SubjectId?: number;
    Weightage?: number;
    Thumbnail?: string;
    IsActive?: boolean;
    ClassTitle?: string;
    SubjectTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class TopicRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Topic';
    static readonly lookupKey = 'Syllabus.Topic';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TopicRow>('Syllabus.Topic') }
    static async getLookupAsync() { return getLookupAsync<TopicRow>('Syllabus.Topic') }

    static readonly deletePermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly insertPermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly readPermission = 'Syllabus:SyllabusManagement:View';
    static readonly updatePermission = 'Syllabus:SyllabusManagement:Modify';

    static readonly Fields = fieldsProxy<TopicRow>();
}