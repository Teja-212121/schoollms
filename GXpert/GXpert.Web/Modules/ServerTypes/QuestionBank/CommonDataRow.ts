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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CommonDataRow>();
}