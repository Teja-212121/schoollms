import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EDifficultyLevel } from "../Web/Enums.EDifficultyLevel";
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
}

export class ExamQuestionColumns extends ColumnsBase<ExamQuestionRow> {
    static readonly columnsKey = 'Exams.ExamQuestion';
    static readonly Fields = fieldsProxy<ExamQuestionColumns>();
}

[EDifficultyLevel]; // referenced types