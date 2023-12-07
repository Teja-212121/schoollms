import { Decorators } from "@serenity-is/corelib";

export enum ECountType {
    Unlimited = 1,
    Limited = 2
}
Decorators.registerEnumType(ECountType, 'GXpert.Web.Enums.ECountType');