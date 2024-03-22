import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AcademicPerformanceRow } from "./AcademicPerformanceRow";

export interface AcademicPerformanceColumns {
    Id: Column<AcademicPerformanceRow>;
    StudentPrn: Column<AcademicPerformanceRow>;
    CourseTitle: Column<AcademicPerformanceRow>;
    ClassTitle: Column<AcademicPerformanceRow>;
    SemesterTitle: Column<AcademicPerformanceRow>;
    MarksObtained: Column<AcademicPerformanceRow>;
    OutOfMarks: Column<AcademicPerformanceRow>;
    Remarks: Column<AcademicPerformanceRow>;
    AcademicYearName: Column<AcademicPerformanceRow>;
}

export class AcademicPerformanceColumns extends ColumnsBase<AcademicPerformanceRow> {
    static readonly columnsKey = 'Masters.AcademicPerformance';
    static readonly Fields = fieldsProxy<AcademicPerformanceColumns>();
}