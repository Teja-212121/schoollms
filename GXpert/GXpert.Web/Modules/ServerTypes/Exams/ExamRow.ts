import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EExamState } from "../Web/Enums.EExamState";
import { EExamTypes } from "../Web/Enums.EExamTypes";
import { EOptionDisplayTypes } from "../Web/Enums.EOptionDisplayTypes";
import { EQuestionNavigation } from "../Web/Enums.EQuestionNavigation";
import { EResultTypes } from "../Web/Enums.EResultTypes";
import { ExamQuestionRow } from "./ExamQuestionRow";
import { ExamSectionRow } from "./ExamSectionRow";

export interface ExamRow {
    Id?: number;
    Title?: string;
    EExamType?: EExamTypes;
    EExamState?: EExamState;
    QuestionPaperPath?: string;
    ModelAnswerPaperPath?: string;
    ExamDuration?: number;
    MaxMarks?: number;
    NegativeMarks?: number;
    EExamNavigation?: EQuestionNavigation;
    ESectionNavigation?: EQuestionNavigation;
    EQuestionNavigation?: EQuestionNavigation;
    EResultType?: EResultTypes;
    EOptionDisplayType?: EOptionDisplayTypes;
    HasNegativeMarketing?: boolean;
    Instructions?: string;
    SearchTags?: string;
    ExamSection?: ExamSectionRow[];
    ExamQuestions?: ExamQuestionRow[];
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

    static readonly deletePermission = 'Exams:ExamsManagement:Modify';
    static readonly insertPermission = 'Exams:ExamsManagement:Modify';
    static readonly readPermission = 'Exams:ExamsManagement:View';
    static readonly updatePermission = 'Exams:ExamsManagement:Modify';

    static readonly Fields = fieldsProxy<ExamRow>();
}