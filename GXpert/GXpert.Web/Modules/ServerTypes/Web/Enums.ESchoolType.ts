import { Decorators } from "@serenity-is/corelib";

export enum ESchoolType {
    GOVERNMENT = 0,
    PRIVATE = 1
}
Decorators.registerEnumType(ESchoolType, 'GXpert.Web.Enums.ESchoolType');