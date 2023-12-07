import { Decorators } from "@serenity-is/corelib";

export enum EValidityType {
    UNLIMITED = 0,
    FIXEDDATE = 1,
    VALIDITYINDAYS = 2
}
Decorators.registerEnumType(EValidityType, 'GXpert.Web.Enums.EValidityType');