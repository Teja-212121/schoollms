import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ExamSectionRow {
    Id?: number;
    ExamId?: number;
    Title?: string;
    Instructions?: string;
    DurationInSeconds?: number;
    SortOrder?: number;
    ParentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    SubjectId?: number;
    TopicId?: number;
    NumberOfQuestions?: number;
    NumberOfMandatoryQuestions?: number;
    SearchTags?: string;
    IsActive?: boolean;
    ExamTitle?: string;
    ParentTitle?: string;
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

export abstract class ExamSectionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Exams.ExamSection';
    static readonly lookupKey = 'Exams.Exam Section';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamSectionRow>('Exams.Exam Section') }
    static async getLookupAsync() { return getLookupAsync<ExamSectionRow>('Exams.Exam Section') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamSectionRow>();
}