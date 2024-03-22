import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DepartmentRow } from "./DepartmentRow";

export interface DepartmentColumns {
    Id: Column<DepartmentRow>;
    Title: Column<DepartmentRow>;
    InstituteName: Column<DepartmentRow>;
    HodName: Column<DepartmentRow>;
    Description: Column<DepartmentRow>;
}

export class DepartmentColumns extends ColumnsBase<DepartmentRow> {
    static readonly columnsKey = 'Institute.Department';
    static readonly Fields = fieldsProxy<DepartmentColumns>();
}