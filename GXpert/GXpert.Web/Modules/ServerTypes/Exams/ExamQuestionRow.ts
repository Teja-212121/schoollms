import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";

export interface ExamQuestionRow {
    Id?: number;
    ExamId?: number;
    RowIds?: string;
    ExamSectionId?: number;
    QuestionId?: number;
    EDifficultyLevel?: EDifficultyLevel;
    RightAnswer?: string;
    Marks?: number;
    SortOrder?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    SubjectId?: number;
    TopicId?: number;
    IsActive?: boolean;
    ExamTitle?: string;
    ExamSectionTitle?: string;
    QuestionText?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamQuestionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'RightAnswer';
    static readonly localTextPrefix = 'Exams.ExamQuestion';
    static readonly lookupKey = 'Exams.ExamQuestion';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamQuestionRow>('Exams.ExamQuestion') }
    static async getLookupAsync() { return getLookupAsync<ExamQuestionRow>('Exams.ExamQuestion') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamQuestionRow>();
}