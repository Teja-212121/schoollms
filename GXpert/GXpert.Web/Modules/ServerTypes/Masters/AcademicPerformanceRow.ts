import { fieldsProxy } from "@serenity-is/corelib";

export interface AcademicPerformanceRow {
    Id?: number;
    StudentId?: number;
    CourseId?: number;
    ClassId?: number;
    SemesterId?: number;
    MarksObtained?: number;
    OutOfMarks?: number;
    Remarks?: string;
    AcademicYearId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    CourseTitle?: string;
    ClassTitle?: string;
    SemesterTitle?: string;
    AcademicYearName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AcademicPerformanceRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Remarks';
    static readonly localTextPrefix = 'Masters.AcademicPerformance';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AcademicPerformanceRow>();
}