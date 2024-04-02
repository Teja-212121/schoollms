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
    static readonly deletePermission = 'Attendance:AttendanceManagement:Modify';
    static readonly insertPermission = 'Attendance:AttendanceManagement:Modify';
    static readonly readPermission = 'Attendance:AttendanceManagement:View';
    static readonly updatePermission = 'Attendance:AttendanceManagement:Modify';

    static readonly Fields = fieldsProxy<AssignmentAttemptRow>();
}