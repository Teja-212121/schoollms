import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SchoolClassRow } from "./SchoolClassRow";

export interface SchoolClassColumns {
    Id: Column<SchoolClassRow>;
    ClassTitle: Column<SchoolClassRow>;
    Division: Column<SchoolClassRow>;
    MediumTitle: Column<SchoolClassRow>;
    ClassTeacherPrn: Column<SchoolClassRow>;
    Title: Column<SchoolClassRow>;
    AcademicYearName: Column<SchoolClassRow>;
}

export class SchoolClassColumns extends ColumnsBase<SchoolClassRow> {
    static readonly columnsKey = 'Schools.SchoolClass';
    static readonly Fields = fieldsProxy<SchoolClassColumns>();
}