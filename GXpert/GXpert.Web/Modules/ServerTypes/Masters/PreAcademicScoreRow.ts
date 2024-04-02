import { fieldsProxy } from "@serenity-is/corelib";

export interface PreAcademicScoreRow {
    Id?: number;
    PreAcadamicsId?: number;
    PassedOutDate?: string;
    MarksObtained?: number;
    OutOfMarks?: number;
    StudentId?: number;
    Remarks?: string;
    IsActive?: boolean;
    PreAcadamicsExamName?: string;
    StudentPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PreAcademicScoreRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Remarks';
    static readonly localTextPrefix = 'Masters.PreAcademicScore';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<PreAcademicScoreRow>();
}