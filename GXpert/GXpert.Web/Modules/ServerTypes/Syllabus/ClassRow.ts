import { fieldsProxy } from "@serenity-is/corelib";

export interface ClassRow {
    Id?: number;
    Title?: string;
    Description?: string;
    SortOrder?: number;
    Weightage?: number;
    Thumbnail?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
}

export abstract class ClassRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Class';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ClassRow>();
}