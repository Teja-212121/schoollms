import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SubjectRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    ClassId?: number;
    MediumId?: number;
    Weightage?: number;
    Thumbnail?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ClassTitle?: string;
    MediumTitle?: string;
}

export abstract class SubjectRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Subject';
    static readonly lookupKey = 'Syllabus.Subject';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SubjectRow>('Syllabus.Subject') }
    static async getLookupAsync() { return getLookupAsync<SubjectRow>('Syllabus.Subject') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SubjectRow>();
}