import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { StudentRow } from "./StudentRow";

export interface StudentColumns {
    Id: Column<StudentRow>;
    Prn: Column<StudentRow>;
    Name: Column<StudentRow>;
    Email: Column<StudentRow>;
    Mobile: Column<StudentRow>;
    Username: Column<StudentRow>;
    AddressLine1: Column<StudentRow>;
    AddressLine2: Column<StudentRow>;
    InstituteName: Column<StudentRow>;
    DepartmentTitle: Column<StudentRow>;
    BranchTitle: Column<StudentRow>;
    InstituteDivision: Column<StudentRow>;
    CourseTitle: Column<StudentRow>;
    ClassTitle: Column<StudentRow>;
    SemesterTitle: Column<StudentRow>;
    AcademicYearName: Column<StudentRow>;
    Description: Column<StudentRow>;
    StateTitle: Column<StudentRow>;
    DistrictTitle: Column<StudentRow>;
    TalukaTitle: Column<StudentRow>;
    Dob: Column<StudentRow>;
}

export class StudentColumns extends ColumnsBase<StudentRow> {
    static readonly columnsKey = 'Users.Student';
    static readonly Fields = fieldsProxy<StudentColumns>();
}