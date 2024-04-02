import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignedExamTeachersRow {
    Id?: number;
    ExamId?: number;
    PlayListId?: number;
    TeacherId?: number;
    IsActive?: boolean;
    ExamTitle?: string;
    PlayListTitle?: string;
    TeacherPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AssignedExamTeachersRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Analytics.AssignedExamTeachers';
    static readonly deletePermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly insertPermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly readPermission = 'Analytics:AnalyticsManagement:View';
    static readonly updatePermission = 'Analytics:AnalyticsManagement:Modify';

    static readonly Fields = fieldsProxy<AssignedExamTeachersRow>();
}