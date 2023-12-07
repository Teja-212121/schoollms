import { Decorators } from "@serenity-is/corelib";

export enum EResultTypes {
    AFTER_EXAM_ON_SERVER = 0,
    AFTER_EXAM_ON_CLIENT = 1,
    AFTER_QUESTION_ON_CLIENT = 2
}
Decorators.registerEnumType(EResultTypes, 'GXpert.Web.Enums.EResultTypes', 'Workspace.EResultTypes');