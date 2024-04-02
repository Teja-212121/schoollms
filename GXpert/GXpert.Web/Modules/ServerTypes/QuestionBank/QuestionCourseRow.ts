import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface QuestionCourseRow {
    Id?: number;
    QuestionId?: number;
    CourseId?: number;
    ClassId?: number;
    TopicId?: number;
    SubjectId?: number;
    SemesterId?: number;
    IsActive?: number;
    QuestionText?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    TopicTitle?: string;
    SubjectTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class QuestionCourseRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'QuestionBank.QuestionCourse';
    static readonly lookupKey = 'QuestionBank.Question Course';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<QuestionCourseRow>('QuestionBank.Question Course') }
    static async getLookupAsync() { return getLookupAsync<QuestionCourseRow>('QuestionBank.Question Course') }

    static readonly deletePermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly insertPermission = 'QuestionBank:QuestionBankManagement:Modify';
    static readonly readPermission = 'QuestionBank:QuestionBankManagement:View';
    static readonly updatePermission = 'QuestionBank:QuestionBankManagement:Modify';

    static readonly Fields = fieldsProxy<QuestionCourseRow>();
}