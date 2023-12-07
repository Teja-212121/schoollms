import { Decorators } from "@serenity-is/corelib";

export enum ECountType {
    UNLIMITED = 0,
    LIMITED = 1
}
Decorators.registerEnumType(ECountType, 'GXpert.Web.Enums.ECountType');