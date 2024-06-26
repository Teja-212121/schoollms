﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EInstituteTimeTableType } from "../Web/Enums.EInstituteTimeTableType";
import { InstituteTimeTableRow } from "./InstituteTimeTableRow";

export interface InstituteTimeTableColumns {
    Id: Column<InstituteTimeTableRow>;
    Date: Column<InstituteTimeTableRow>;
    StartTime: Column<InstituteTimeTableRow>;
    EndTime: Column<InstituteTimeTableRow>;
    PeriodIndex: Column<InstituteTimeTableRow>;
    TeacherPrn: Column<InstituteTimeTableRow>;
    InstituteName: Column<InstituteTimeTableRow>;
    DepartmentName: Column<InstituteTimeTableRow>;
    BranchName: Column<InstituteTimeTableRow>;
    InstitudeDivisionName: Column<InstituteTimeTableRow>;
    EType: Column<InstituteTimeTableRow>;
    ClassRoomNo: Column<InstituteTimeTableRow>;
    TeacherAttendanceStatus: Column<InstituteTimeTableRow>;
}

export class InstituteTimeTableColumns extends ColumnsBase<InstituteTimeTableRow> {
    static readonly columnsKey = 'Institute.InstituteTimeTable';
    static readonly Fields = fieldsProxy<InstituteTimeTableColumns>();
}

[EInstituteTimeTableType]; // referenced types