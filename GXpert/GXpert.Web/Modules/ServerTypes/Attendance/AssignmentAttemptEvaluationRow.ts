import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentAttemptEvaluationRow {
    Id?: number;
    AssignmentId?: number;
    AssignmentAttemptId?: number;
    AssignmentEvaluationId?: number;
    MarksObtained?: number;
    EvaluationStatus?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    AssignmentAttemptFileUploaded?: string;
    AssignmentEvaluationEvalutionCriteria?: string;
}

export abstract class AssignmentAttemptEvaluationRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.AssignmentAttemptEvaluation';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignmentAttemptEvaluationRow>();
}