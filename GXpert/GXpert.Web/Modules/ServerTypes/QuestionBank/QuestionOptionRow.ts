import { fieldsProxy } from "@serenity-is/corelib";

export interface QuestionOptionRow {
    Id?: number;
    QuestionId?: number;
    OptionText?: string;
    IsCorrect?: boolean;
    SortOrder?: number;
    Weightage?: number;
    IsActive?: boolean;
    QuestionText?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class QuestionOptionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'OptionText';
    static readonly localTextPrefix = 'QuestionBank.QuestionOption';
    static readonly deletePermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly insertPermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly readPermission = 'QuestionBank:QuestionBankManagement:View';
    static readonly updatePermission = 'QuestionBank:QuestionBankManagement:Modify';

    static readonly Fields = fieldsProxy<QuestionOptionRow>();
}