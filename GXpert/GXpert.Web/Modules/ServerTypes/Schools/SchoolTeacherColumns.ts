import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SchoolTeacherRow } from "./SchoolTeacherRow";

export interface SchoolTeacherColumns {
    Id: Column<SchoolTeacherRow>;
    TeacherPrn: Column<SchoolTeacherRow>;
    SchoolName: Column<SchoolTeacherRow>;
    ClassTitle: Column<SchoolTeacherRow>;
    SubjectTitle: Column<SchoolTeacherRow>;
    Description: Column<SchoolTeacherRow>;
    AcademicYearName: Column<SchoolTeacherRow>;
    InsertDate: Column<SchoolTeacherRow>;
    InsertUserId: Column<SchoolTeacherRow>;
    UpdateDate: Column<SchoolTeacherRow>;
    UpdateUserId: Column<SchoolTeacherRow>;
    IsActive: Column<SchoolTeacherRow>;
}

export class SchoolTeacherColumns extends ColumnsBase<SchoolTeacherRow> {
    static readonly columnsKey = 'Schools.SchoolTeacher';
    static readonly Fields = fieldsProxy<SchoolTeacherColumns>();
}