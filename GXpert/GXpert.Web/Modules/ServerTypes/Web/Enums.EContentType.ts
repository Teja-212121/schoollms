import { Decorators } from "@serenity-is/corelib";

export enum EContentType {
    Video = 1,
    Audio = 2,
    Pdf = 3,
    Exam = 4,
    Html = 5,
    Meeting = 6
}
Decorators.registerEnumType(EContentType, 'GXpert.Web.Enums.EContentType');