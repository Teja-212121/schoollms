import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TeacherRow } from "./TeacherRow";

export interface TeacherColumns {
    Id: Column<TeacherRow>;
    Prn: Column<TeacherRow>;
    Name: Column<TeacherRow>;
    Email: Column<TeacherRow>;
    Mobile: Column<TeacherRow>;
    Username: Column<TeacherRow>;
    Description: Column<TeacherRow>;
    StateTitle: Column<TeacherRow>;
    DistrictTitle: Column<TeacherRow>;
    TalukaTitle: Column<TeacherRow>;
    Dob: Column<TeacherRow>;
    SchoolName: Column<TeacherRow>;
}

export class TeacherColumns extends ColumnsBase<TeacherRow> {
    static readonly columnsKey = 'Users.Teacher';
    static readonly Fields = fieldsProxy<TeacherColumns>();
}