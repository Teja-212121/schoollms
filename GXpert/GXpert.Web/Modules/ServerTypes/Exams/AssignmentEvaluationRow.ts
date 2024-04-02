import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentEvaluationRow {
    Id?: number;
    AssignmentId?: number;
    EvalutionCriteria?: string;
    ClassId?: number;
    SubjectId?: number;
    TopicId?: number;
    BloomsIndex?: number;
    BloomsWeightage?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    BloomsIndexCoginitiveSkill?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AssignmentEvaluationRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EvalutionCriteria';
    static readonly localTextPrefix = 'Exams.AssignmentEvaluation';
    static readonly lookupKey = 'Exams.AssignmentEvaluation';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AssignmentEvaluationRow>('Exams.AssignmentEvaluation') }
    static async getLookupAsync() { return getLookupAsync<AssignmentEvaluationRow>('Exams.AssignmentEvaluation') }

    static readonly deletePermission = 'Exams:ExamsManagement:Modify';
    static readonly insertPermission = 'Exams:ExamsManagement:Modify';
    static readonly readPermission = 'Exams:ExamsManagement:View';
    static readonly updatePermission = 'Exams:ExamsManagement:Modify';

    static readonly Fields = fieldsProxy<AssignmentEvaluationRow>();
}