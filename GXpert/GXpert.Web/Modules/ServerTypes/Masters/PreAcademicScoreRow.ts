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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PreAcademicScoreRow>();
}