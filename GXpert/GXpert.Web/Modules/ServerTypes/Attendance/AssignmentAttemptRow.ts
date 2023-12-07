import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignmentAttemptRow {
    Id?: number;
    AssignmentId?: number;
    StudentId?: number;
    FileUploaded?: string;
    EStatus?: string;
    TeacherId?: number;
    PlayListId?: number;
    ActivationId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    StudentPrn?: string;
    TeacherPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
}

export abstract class AssignmentAttemptRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FileUploaded';
    static readonly localTextPrefix = 'Attendance.AssignmentAttempt';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignmentAttemptRow>();
}