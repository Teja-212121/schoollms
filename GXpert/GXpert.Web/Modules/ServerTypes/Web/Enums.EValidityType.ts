import { Decorators } from "@serenity-is/corelib";

export enum EValidityType {
    Unlimited = 1,
    FixedDate = 2,
    ValidityInDays = 3
}
Decorators.registerEnumType(EValidityType, 'GXpert.Web.Enums.EValidityType');