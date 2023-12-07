import { fieldsProxy } from "@serenity-is/corelib";

export interface ExamRow {
    Id?: number;
    Title?: string;
    EExamType?: number;
    EExamState?: number;
    QuestionPaperPath?: string;
    ModelAnswerPaperPath?: string;
    ExamDuration?: number;
    MaxMarks?: number;
    NegativeMarks?: number;
    EExamNavigation?: number;
    ESectionNavigation?: number;
    EQuestionNavigation?: number;
    EResultType?: number;
    EOptionDisplayType?: number;
    HasNegativeMarketing?: boolean;
    Instructions?: string;
    SearchTags?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
}

export abstract class ExamRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.Exam';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamRow>();
}