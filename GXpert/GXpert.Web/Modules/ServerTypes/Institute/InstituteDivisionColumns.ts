import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { InstituteDivisionRow } from "./InstituteDivisionRow";

export interface InstituteDivisionColumns {
    Id: Column<InstituteDivisionRow>;
    ClassTitle: Column<InstituteDivisionRow>;
    SemesterTitle: Column<InstituteDivisionRow>;
    Division: Column<InstituteDivisionRow>;
    ClassTeacherPrn: Column<InstituteDivisionRow>;
    Title: Column<InstituteDivisionRow>;
    AcademicYearName: Column<InstituteDivisionRow>;
    InstituteName: Column<InstituteDivisionRow>;
    DepartmentTitle: Column<InstituteDivisionRow>;
    CourseTitle: Column<InstituteDivisionRow>;
}

export class InstituteDivisionColumns extends ColumnsBase<InstituteDivisionRow> {
    static readonly columnsKey = 'Institute.InstituteDivision';
    static readonly Fields = fieldsProxy<InstituteDivisionColumns>();
}