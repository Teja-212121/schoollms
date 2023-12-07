import { fieldsProxy } from "@serenity-is/corelib";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";

export interface ExamAttemptRow {
    Id?: number;
    ExamId?: number;
    StudentId?: number;
    TeacherId?: number;
    EStatus?: EExamAttemptStatus;
    TimeSpent?: number;
    PlayListId?: number;
    StudentAnswerSheetUpload?: string;
    TeacherCheckedPaperUpload?: string;
    ActivationId?: number;
    IsActive?: boolean;
    ExamTitle?: string;
    StudentPrn?: string;
    TeacherPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamAttemptRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'StudentAnswerSheetUpload';
    static readonly localTextPrefix = 'Analytics.ExamAttempt';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamAttemptRow>();
}