import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EAttendanceStatus } from "../Web/Enums.EAttendanceStatus";
import { StudentClassAttendanceRow } from "./StudentClassAttendanceRow";

export interface StudentClassAttendanceColumns {
    Id: Column<StudentClassAttendanceRow>;
    InstituteTimeTableId: Column<StudentClassAttendanceRow>;
    StudentPrn: Column<StudentClassAttendanceRow>;
    AttendanceStatus: Column<StudentClassAttendanceRow>;
}

export class StudentClassAttendanceColumns extends ColumnsBase<StudentClassAttendanceRow> {
    static readonly columnsKey = 'Attendance.StudentClassAttendance';
    static readonly Fields = fieldsProxy<StudentClassAttendanceColumns>();
}

[EAttendanceStatus]; // referenced types