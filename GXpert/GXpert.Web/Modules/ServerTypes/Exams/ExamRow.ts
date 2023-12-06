import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

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
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.Exam';
    static readonly lookupKey = 'Exams.Exam';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamRow>('Exams.Exam') }
    static async getLookupAsync() { return getLookupAsync<ExamRow>('Exams.Exam') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamRow>();
}