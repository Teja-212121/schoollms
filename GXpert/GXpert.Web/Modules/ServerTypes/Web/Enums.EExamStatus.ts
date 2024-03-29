import { Decorators } from "@serenity-is/corelib";

export enum EExamStatus {
    DRAFT = 0,
    PUBLISHED = 1,
    UNPUBLISHED = 2
}
Decorators.registerEnumType(EExamStatus, 'GXpert.Web.Enums.EExamStatus');