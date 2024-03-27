import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CourseRow } from "./CourseRow";

export interface CourseColumns {
    Id: Column<CourseRow>;
    Title: Column<CourseRow>;
    SortOrder: Column<CourseRow>;
    Thumbnail: Column<CourseRow>;
    Description: Column<CourseRow>;
}

export class CourseColumns extends ColumnsBase<CourseRow> {
    static readonly columnsKey = 'Syllabus.Course';
    static readonly Fields = fieldsProxy<CourseColumns>();
}