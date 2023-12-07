import { Decorators } from "@serenity-is/corelib";

export enum EQuestionType {
    SINGLE_RIGHT_ANSWER = 0,
    MULTIPLE_RIGHT_ANSWER = 1,
    TRUE_OR_FALSE = 2,
    NUMERICAL = 3,
    FILL_IN_THE_BLANK = 4,
    MATCHING = 5,
    ORDER_OR_SEQUENCING = 6
}
Decorators.registerEnumType(EQuestionType, 'GXpert.Web.Enums.EQuestionType', 'Workspace.EQuestionTypes');