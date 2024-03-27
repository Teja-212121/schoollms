import { Decorators } from "@serenity-is/corelib";

export enum EGender {
    Female = 1,
    Male = 5,
    Transgender = 10
}
Decorators.registerEnumType(EGender, 'GXpert.Web.Enums.EGender');