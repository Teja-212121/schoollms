import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SchoolTimeTableRow } from "./SchoolTimeTableRow";

export interface SchoolTimeTableColumns {
    Id: Column<SchoolTimeTableRow>;
    Date: Column<SchoolTimeTableRow>;
    StartTime: Column<SchoolTimeTableRow>;
    EndTime: Column<SchoolTimeTableRow>;
    PeriodIndex: Column<SchoolTimeTableRow>;
    SchoolClassDivision: Column<SchoolTimeTableRow>;
    TeacherPrn: Column<SchoolTimeTableRow>;
    EType: Column<SchoolTimeTableRow>;
    InsertDate: Column<SchoolTimeTableRow>;
    InsertUserId: Column<SchoolTimeTableRow>;
    UpdateDate: Column<SchoolTimeTableRow>;
    UpdateUserId: Column<SchoolTimeTableRow>;
    IsActive: Column<SchoolTimeTableRow>;
}

export class SchoolTimeTableColumns extends ColumnsBase<SchoolTimeTableRow> {
    static readonly columnsKey = 'Schools.SchoolTimeTable';
    static readonly Fields = fieldsProxy<SchoolTimeTableColumns>();
}