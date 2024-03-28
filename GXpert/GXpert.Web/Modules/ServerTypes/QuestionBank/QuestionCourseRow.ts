import { fieldsProxy } from "@serenity-is/corelib";

export interface QuestionCourseRow {
    Id?: number;
    QuestionId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    UserId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    QuestionText?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    Username?: string;
}

export abstract class QuestionCourseRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'QuestionBank.QuestionCourse';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<QuestionCourseRow>();
}