import { fieldsProxy } from "@serenity-is/corelib";

export interface PreAcademicRow {
    Id?: number;
    ExamName?: string;
    Description?: string;
    Thumbnail?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PreAcademicRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ExamName';
    static readonly localTextPrefix = 'Masters.PreAcademic';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PreAcademicRow>();
}