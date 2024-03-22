﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteTeacherRow {
    Id?: number;
    TeacherId?: number;
    SchoolId?: number;
    ClassId?: number;
    SubjectId?: number;
    Description?: string;
    AcademicYearId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    TeacherPrn?: string;
    SchoolName?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    AcademicYearName?: string;
}

export abstract class InstituteTeacherRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Description';
    static readonly localTextPrefix = 'Institute.InstituteTeacher';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteTeacherRow>();
}