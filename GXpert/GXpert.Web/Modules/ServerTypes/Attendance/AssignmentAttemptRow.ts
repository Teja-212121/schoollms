import { fieldsProxy } from "@serenity-is/corelib";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";

export interface AssignmentAttemptRow {
    Id?: number;
    AssignmentId?: number;
    StudentId?: number;
    FileUploaded?: string;
    EStatus?: EExamAttemptStatus;
    TeacherId?: number;
    PlayListId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    AssignmentTitle?: string;
    StudentPrn?: string;
    TeacherPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
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