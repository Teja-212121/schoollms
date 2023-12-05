import { fieldsProxy } from "@serenity-is/corelib";

export interface ExamSectionRow {
    Id?: number;
    ExamId?: number;
    Title?: string;
    Instructions?: string;
    DurationInSeconds?: number;
    SortOrder?: number;
    ParentId?: number;
    NumberOfQuestions?: number;
    NumberOfMandatoryQuestions?: number;
    SearchTags?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ExamTitle?: string;
    ParentTitle?: string;
}

export abstract class ExamSectionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.ExamSection';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamSectionRow>();
}