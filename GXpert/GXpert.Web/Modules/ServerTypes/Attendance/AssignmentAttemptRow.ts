import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentAttemptRow {
    Id?: number;
    AssignmentId?: number;
    StudentId?: number;
    FileUploaded?: string;
    EStatus?: string;
    TeacherId?: number;
    PlayListId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    StudentPrn?: string;
    TeacherPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AssignmentAttemptRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FileUploaded';
    static readonly localTextPrefix = 'Attendance.AssignmentAttempt';
    static readonly lookupKey = 'Exams.AssignmentEvaluation';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AssignmentAttemptRow>('Exams.AssignmentEvaluation') }
    static async getLookupAsync() { return getLookupAsync<AssignmentAttemptRow>('Exams.AssignmentEvaluation') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignmentAttemptRow>();
}