import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentRow {
    Id?: number;
    Title?: string;
    Description?: string;
    File?: string;
    ClassId?: number;
    SubjectId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ClassTitle?: string;
    SubjectTitle?: string;
}

export abstract class AssignmentRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.Assignment';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignmentRow>();
}