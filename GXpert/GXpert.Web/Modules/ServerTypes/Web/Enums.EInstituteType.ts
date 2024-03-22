import { Decorators } from "@serenity-is/corelib";

export enum EInstituteType {
    GOVERNMENT = 0,
    PRIVATE = 1
}
Decorators.registerEnumType(EInstituteType, 'GXpert.Web.Enums.EInstituteType');