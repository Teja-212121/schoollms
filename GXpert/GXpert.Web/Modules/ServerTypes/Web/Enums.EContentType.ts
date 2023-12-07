import { Decorators } from "@serenity-is/corelib";

export enum EContentType {
    VIDEO = 0,
    AUDIO = 1,
    PDF = 2,
    EXAM = 3,
    HTML = 4,
    MEETING = 5
}
Decorators.registerEnumType(EContentType, 'GXpert.Web.Enums.EContentType');