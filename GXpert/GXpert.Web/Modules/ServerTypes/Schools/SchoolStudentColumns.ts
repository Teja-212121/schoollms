import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SchoolStudentRow } from "./SchoolStudentRow";

export interface SchoolStudentColumns {
    Id: Column<SchoolStudentRow>;
    StudentPrn: Column<SchoolStudentRow>;
    SchoolName: Column<SchoolStudentRow>;
    ClassTitle: Column<SchoolStudentRow>;
    Division: Column<SchoolStudentRow>;
    RollNumber: Column<SchoolStudentRow>;
    Description: Column<SchoolStudentRow>;
    AcademicYearName: Column<SchoolStudentRow>;
}

export class SchoolStudentColumns extends ColumnsBase<SchoolStudentRow> {
    static readonly columnsKey = 'Schools.SchoolStudent';
    static readonly Fields = fieldsProxy<SchoolStudentColumns>();
}