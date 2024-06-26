﻿import { fieldsProxy } from "@serenity-is/corelib";
import { ETypeOfExam } from "../Web/Enums.ETypeOfExam";

export interface AcademicSubjectPerformanceRow {
    Id?: number;
    StudentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    SubjectId?: number;
    ETypeOfExam?: ETypeOfExam;
    MarksObtained?: number;
    OutOfMarks?: number;
    Remarks?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    SubjectTitle?: string;
    AcademicYearName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AcademicSubjectPerformanceRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Remarks';
    static readonly localTextPrefix = 'Masters.AcademicSubjectPerformance';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<AcademicSubjectPerformanceRow>();
}