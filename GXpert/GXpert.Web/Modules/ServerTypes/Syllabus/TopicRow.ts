import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface TopicRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    ClassId?: number;
    MediumId?: number;
    SubjectId?: number;
    Weightage?: number;
    Thumbnail?: string;
    IsActive?: boolean;
    ClassTitle?: string;
    MediumTitle?: string;
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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TopicRow>();
}