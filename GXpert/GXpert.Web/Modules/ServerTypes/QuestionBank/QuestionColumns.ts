import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { QuestionRow } from "./QuestionRow";

export interface QuestionColumns {
    Id: Column<QuestionRow>;
    QuestionText: Column<QuestionRow>;
    Explaination: Column<QuestionRow>;
    IsSubjective: Column<QuestionRow>;
    EQuestionType: Column<QuestionRow>;
    EDifficultyLevel: Column<QuestionRow>;
    QuestionCommonDataCommonDataTitle: Column<QuestionRow>;
    QuestionCommonDataSortOrder: Column<QuestionRow>;
    ClassTitle: Column<QuestionRow>;
    SubjectTitle: Column<QuestionRow>;
    TopicTitle: Column<QuestionRow>;
    BloomsIndexCoginitiveSkill: Column<QuestionRow>;
    BloomsWeightage: Column<QuestionRow>;
}

export class QuestionColumns extends ColumnsBase<QuestionRow> {
    static readonly columnsKey = 'QuestionBank.Question';
    static readonly Fields = fieldsProxy<QuestionColumns>();
}