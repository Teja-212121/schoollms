import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ExamQuestionRow } from "./ExamQuestionRow";

export interface ExamQuestionColumns {
    Id: Column<ExamQuestionRow>;
    ExamTitle: Column<ExamQuestionRow>;
    ExamSectionTitle: Column<ExamQuestionRow>;
    QuestionText: Column<ExamQuestionRow>;
    EDifficultyLevel: Column<ExamQuestionRow>;
    RightAnswer: Column<ExamQuestionRow>;
    Marks: Column<ExamQuestionRow>;
    SortOrder: Column<ExamQuestionRow>;
    ClassTitle: Column<ExamQuestionRow>;
    SubjectTitle: Column<ExamQuestionRow>;
    TopicTitle: Column<ExamQuestionRow>;
    InsertDate: Column<ExamQuestionRow>;
    InsertUserId: Column<ExamQuestionRow>;
    UpdateDate: Column<ExamQuestionRow>;
    UpdateUserId: Column<ExamQuestionRow>;
    IsActive: Column<ExamQuestionRow>;
}

export class ExamQuestionColumns extends ColumnsBase<ExamQuestionRow> {
    static readonly columnsKey = 'Exams.ExamQuestion';
    static readonly Fields = fieldsProxy<ExamQuestionColumns>();
}