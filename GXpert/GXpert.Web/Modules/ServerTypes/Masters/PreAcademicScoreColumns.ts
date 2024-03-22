import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PreAcademicScoreRow } from "./PreAcademicScoreRow";

export interface PreAcademicScoreColumns {
    Id: Column<PreAcademicScoreRow>;
    PreAcadamicsExamName: Column<PreAcademicScoreRow>;
    PassedOutDate: Column<PreAcademicScoreRow>;
    MarksObtained: Column<PreAcademicScoreRow>;
    OutOfMarks: Column<PreAcademicScoreRow>;
    StudentPrn: Column<PreAcademicScoreRow>;
    Remarks: Column<PreAcademicScoreRow>;
}

export class PreAcademicScoreColumns extends ColumnsBase<PreAcademicScoreRow> {
    static readonly columnsKey = 'Masters.PreAcademicScore';
    static readonly Fields = fieldsProxy<PreAcademicScoreColumns>();
}