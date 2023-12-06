import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AssignmentRow } from "./AssignmentRow";

export interface AssignmentColumns {
    Id: Column<AssignmentRow>;
    Title: Column<AssignmentRow>;
    Description: Column<AssignmentRow>;
    File: Column<AssignmentRow>;
    ClassTitle: Column<AssignmentRow>;
    SubjectTitle: Column<AssignmentRow>;
}

export class AssignmentColumns extends ColumnsBase<AssignmentRow> {
    static readonly columnsKey = 'Exams.Assignment';
    static readonly Fields = fieldsProxy<AssignmentColumns>();
}