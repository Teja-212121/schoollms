import { fieldsProxy } from "@serenity-is/corelib";

export interface CommonDataRow {
    Id?: number;
    CommonDataTitle?: string;
    CommonData?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class CommonDataRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CommonData';
    static readonly localTextPrefix = 'QuestionBank.CommonData';
    static readonly deletePermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly insertPermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly readPermission = 'QuestionBank:QuestionBankManagement:View';
    static readonly updatePermission = 'QuestionBank:QuestionBankManagement:Modify';

    static readonly Fields = fieldsProxy<CommonDataRow>();
}