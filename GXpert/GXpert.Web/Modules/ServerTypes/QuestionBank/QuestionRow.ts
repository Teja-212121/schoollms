import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";
import { EQuestionType } from "../Web/Enums.EQuestionType";
import { QuestionOptionRow } from "./QuestionOptionRow";

export interface QuestionRow {
    Id?: number;
    QuestionText?: string;
    Explaination?: string;
    IsSubjective?: boolean;
    EQuestionType?: EQuestionType;
    EDifficultyLevel?: EDifficultyLevel;
    QuestionCommonDataId?: number;
    QuestionCommonDataSortOrder?: number;
    ClassId?: number;
    SubjectId?: number;
    TopicId?: number;
    BloomsIndex?: number;
    BloomsWeightage?: number;
    IsActive?: boolean;
    QuestionCommonDataCommonDataTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    BloomsIndexCoginitiveSkill?: string;
    QuestionOptions?: QuestionOptionRow[];
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class QuestionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'QuestionText';
    static readonly localTextPrefix = 'QuestionBank.Question';
    static readonly lookupKey = 'QuestionBank.Question';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<QuestionRow>('QuestionBank.Question') }
    static async getLookupAsync() { return getLookupAsync<QuestionRow>('QuestionBank.Question') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<QuestionRow>();
}