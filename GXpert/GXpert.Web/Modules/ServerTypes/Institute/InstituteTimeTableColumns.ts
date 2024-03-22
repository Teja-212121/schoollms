﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { InstituteTimeTableRow } from "./InstituteTimeTableRow";

export interface InstituteTimeTableColumns {
    Id: Column<InstituteTimeTableRow>;
    Date: Column<InstituteTimeTableRow>;
    StartTime: Column<InstituteTimeTableRow>;
    EndTime: Column<InstituteTimeTableRow>;
    PeriodIndex: Column<InstituteTimeTableRow>;
    SchoolClassDivision: Column<InstituteTimeTableRow>;
    TeacherPrn: Column<InstituteTimeTableRow>;
    EType: Column<InstituteTimeTableRow>;
    InsertDate: Column<InstituteTimeTableRow>;
    InsertUserId: Column<InstituteTimeTableRow>;
    UpdateDate: Column<InstituteTimeTableRow>;
    UpdateUserId: Column<InstituteTimeTableRow>;
    IsActive: Column<InstituteTimeTableRow>;
}

export class InstituteTimeTableColumns extends ColumnsBase<InstituteTimeTableRow> {
    static readonly columnsKey = 'Institute.InstituteTimeTable';
    static readonly Fields = fieldsProxy<InstituteTimeTableColumns>();
}