import { Decorators } from "@serenity-is/corelib";

export enum EExamState {
    DRAFT = 0,
    PUBLISHED = 1,
    UNPUBLISHED = 2
}
Decorators.registerEnumType(EExamState, 'GXpert.Web.Enums.EExamState');