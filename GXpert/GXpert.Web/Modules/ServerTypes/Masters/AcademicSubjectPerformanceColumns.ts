import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AcademicSubjectPerformanceRow } from "./AcademicSubjectPerformanceRow";

export interface AcademicSubjectPerformanceColumns {
    Id: Column<AcademicSubjectPerformanceRow>;
    StudentPrn: Column<AcademicSubjectPerformanceRow>;
    CourseTitle: Column<AcademicSubjectPerformanceRow>;
    ClassTitle: Column<AcademicSubjectPerformanceRow>;
    SemesterTitle: Column<AcademicSubjectPerformanceRow>;
    SubjectTitle: Column<AcademicSubjectPerformanceRow>;
    ETypeOfExam: Column<AcademicSubjectPerformanceRow>;
    MarksObtained: Column<AcademicSubjectPerformanceRow>;
    OutOfMarks: Column<AcademicSubjectPerformanceRow>;
    Remarks: Column<AcademicSubjectPerformanceRow>;
    AcademicYearName: Column<AcademicSubjectPerformanceRow>;
}

export class AcademicSubjectPerformanceColumns extends ColumnsBase<AcademicSubjectPerformanceRow> {
    static readonly columnsKey = 'Masters.AcademicSubjectPerformance';
    static readonly Fields = fieldsProxy<AcademicSubjectPerformanceColumns>();
}