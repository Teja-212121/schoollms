import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { QuestionOptionRow } from "./QuestionOptionRow";

export interface QuestionOptionColumns {
    Id: Column<QuestionOptionRow>;
    QuestionText: Column<QuestionOptionRow>;
    OptionText: Column<QuestionOptionRow>;
    IsCorrect: Column<QuestionOptionRow>;
    SortOrder: Column<QuestionOptionRow>;
    Weightage: Column<QuestionOptionRow>;
}

export class QuestionOptionColumns extends ColumnsBase<QuestionOptionRow> {
    static readonly columnsKey = 'QuestionBank.QuestionOption';
    static readonly Fields = fieldsProxy<QuestionOptionColumns>();
}