import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentRow {
    Id?: number;
    Title?: string;
    Description?: string;
    File?: string;
    ClassId?: number;
    SubjectId?: number;
    IsActive?: boolean;
    ClassTitle?: string;
    SubjectTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AssignmentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.Assignment';
    static readonly lookupKey = 'Exams.Assignment';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AssignmentRow>('Exams.Assignment') }
    static async getLookupAsync() { return getLookupAsync<AssignmentRow>('Exams.Assignment') }

    static readonly deletePermission = 'Exams:ExamsManagement:Modify';
    static readonly insertPermission = 'Exams:ExamsManagement:Modify';
    static readonly readPermission = 'Exams:ExamsManagement:View';
    static readonly updatePermission = 'Exams:ExamsManagement:Modify';

    static readonly Fields = fieldsProxy<AssignmentRow>();
}