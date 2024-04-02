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
    static readonly deletePermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly insertPermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly readPermission = 'Analytics:AnalyticsManagement:View';
    static readonly updatePermission = 'Analytics:AnalyticsManagement:Modify';

    static readonly Fields = fieldsProxy<ExamAttemptRow>();
}