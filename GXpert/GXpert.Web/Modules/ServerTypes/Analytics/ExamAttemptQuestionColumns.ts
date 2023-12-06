import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ExamAttemptQuestionRow } from "./ExamAttemptQuestionRow";

export interface ExamAttemptQuestionColumns {
    Id: Column<ExamAttemptQuestionRow>;
    ExamAttemptStudentAnswerSheetUpload: Column<ExamAttemptQuestionRow>;
    ExamQuestionRightAnswer: Column<ExamAttemptQuestionRow>;
    OptionSelected: Column<ExamAttemptQuestionRow>;
    MarksObtained: Column<ExamAttemptQuestionRow>;
    Attemptstatus: Column<ExamAttemptQuestionRow>;
    OutOfmarks: Column<ExamAttemptQuestionRow>;
    Result: Column<ExamAttemptQuestionRow>;
}

export class ExamAttemptQuestionColumns extends ColumnsBase<ExamAttemptQuestionRow> {
    static readonly columnsKey = 'Analytics.ExamAttemptQuestion';
    static readonly Fields = fieldsProxy<ExamAttemptQuestionColumns>();
}