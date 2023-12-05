import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentEvaluationRow {
    Id?: number;
    AssignmentId?: number;
    EvalutionCriteria?: string;
    ClassId?: number;
    SubjectId?: number;
    TopicId?: number;
    BloomsIndex?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    BloomsIndexCoginitiveSkill?: string;
}

export abstract class AssignmentEvaluationRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EvalutionCriteria';
    static readonly localTextPrefix = 'Exams.AssignmentEvaluation';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignmentEvaluationRow>();
}