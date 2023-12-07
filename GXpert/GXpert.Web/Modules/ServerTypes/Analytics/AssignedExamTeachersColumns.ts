import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AssignedExamTeachersRow } from "./AssignedExamTeachersRow";

export interface AssignedExamTeachersColumns {
    Id: Column<AssignedExamTeachersRow>;
    ExamTitle: Column<AssignedExamTeachersRow>;
    PlayListTitle: Column<AssignedExamTeachersRow>;
    TeacherPrn: Column<AssignedExamTeachersRow>;
}

export class AssignedExamTeachersColumns extends ColumnsBase<AssignedExamTeachersRow> {
    static readonly columnsKey = 'Analytics.AssignedExamTeachers';
    static readonly Fields = fieldsProxy<AssignedExamTeachersColumns>();
}