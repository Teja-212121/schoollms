import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ExamRow } from "./ExamRow";

export interface ExamColumns {
    Id: Column<ExamRow>;
    Title: Column<ExamRow>;
    EExamType: Column<ExamRow>;
    EExamState: Column<ExamRow>;
    QuestionPaperPath: Column<ExamRow>;
    ModelAnswerPaperPath: Column<ExamRow>;
    ExamDuration: Column<ExamRow>;
    MaxMarks: Column<ExamRow>;
    NegativeMarks: Column<ExamRow>;
    EExamNavigation: Column<ExamRow>;
    ESectionNavigation: Column<ExamRow>;
    EQuestionNavigation: Column<ExamRow>;
    EResultType: Column<ExamRow>;
    EOptionDisplayType: Column<ExamRow>;
    HasNegativeMarketing: Column<ExamRow>;
    Instructions: Column<ExamRow>;
    SearchTags: Column<ExamRow>;
    InsertDate: Column<ExamRow>;
    InsertUserId: Column<ExamRow>;
    UpdateDate: Column<ExamRow>;
    UpdateUserId: Column<ExamRow>;
    IsActive: Column<ExamRow>;
}

export class ExamColumns extends ColumnsBase<ExamRow> {
    static readonly columnsKey = 'Exams.Exam';
    static readonly Fields = fieldsProxy<ExamColumns>();
}