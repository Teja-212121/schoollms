import { fieldsProxy } from "@serenity-is/corelib";

export interface QuestionRow {
    Id?: number;
    QuestionText?: string;
    Explaination?: string;
    IsSubjective?: boolean;
    EQuestionType?: number;
    EDifficultyLevel?: number;
    QuestionCommonDataId?: number;
    QuestionCommonDataSortOrder?: number;
    ClassId?: number;
    SubjectId?: number;
    TopicId?: number;
    BloomsIndex?: number;
    BloomsWeightage?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    QuestionCommonDataCommonDataTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    BloomsIndexCoginitiveSkill?: string;
}

export abstract class QuestionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'QuestionText';
    static readonly localTextPrefix = 'QuestionBank.Question';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<QuestionRow>();
}