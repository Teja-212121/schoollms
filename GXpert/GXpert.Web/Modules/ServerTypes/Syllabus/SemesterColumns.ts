import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SemesterRow } from "./SemesterRow";

export interface SemesterColumns {
    Id: Column<SemesterRow>;
    CourseTitle: Column<SemesterRow>;
    ClassTitle: Column<SemesterRow>;
    Title: Column<SemesterRow>;
    SortOrder: Column<SemesterRow>;
    Description: Column<SemesterRow>;
}

export class SemesterColumns extends ColumnsBase<SemesterRow> {
    static readonly columnsKey = 'Syllabus.Semester';
    static readonly Fields = fieldsProxy<SemesterColumns>();
}