import { Decorators } from "@serenity-is/corelib";

export enum ETypeOfExam {
    THEORY = 0,
    PRACTICAL = 1,
    ORAL = 2
}
Decorators.registerEnumType(ETypeOfExam, 'GXpert.Web.Enums.ETypeOfExam');