import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { InstituteClassRow } from "./InstituteClassRow";

export interface InstituteClassColumns {
    Id: Column<InstituteClassRow>;
    ClassTitle: Column<InstituteClassRow>;
    Division: Column<InstituteClassRow>;
    Semester: Column<InstituteClassRow>;
    ClassTeacherPrn: Column<InstituteClassRow>;
    Title: Column<InstituteClassRow>;
    AcademicYearName: Column<InstituteClassRow>;
    InstituteName: Column<InstituteClassRow>;
    DepartmentTitle: Column<InstituteClassRow>;
    CourseTitle: Column<InstituteClassRow>;
}

export class InstituteClassColumns extends ColumnsBase<InstituteClassRow> {
    static readonly columnsKey = 'Institute.InstituteClass';
    static readonly Fields = fieldsProxy<InstituteClassColumns>();
}