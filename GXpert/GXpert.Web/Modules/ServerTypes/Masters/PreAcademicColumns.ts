import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PreAcademicRow } from "./PreAcademicRow";

export interface PreAcademicColumns {
    Id: Column<PreAcademicRow>;
    ExamName: Column<PreAcademicRow>;
    Description: Column<PreAcademicRow>;
    Thumbnail: Column<PreAcademicRow>;
}

export class PreAcademicColumns extends ColumnsBase<PreAcademicRow> {
    static readonly columnsKey = 'Masters.PreAcademic';
    static readonly Fields = fieldsProxy<PreAcademicColumns>();
}