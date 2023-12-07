import { Decorators } from "@serenity-is/corelib";

export enum EQuestionNavigation {
    FREE_STYLE = 0,
    FORWARD_ONLY = 1
}
Decorators.registerEnumType(EQuestionNavigation, 'GXpert.Web.Enums.EQuestionNavigation', 'Workspace.EQuestionNavigation');