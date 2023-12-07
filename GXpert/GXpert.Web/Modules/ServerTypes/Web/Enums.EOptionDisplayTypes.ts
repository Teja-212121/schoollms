import { Decorators } from "@serenity-is/corelib";

export enum EOptionDisplayTypes {
    NUMERIC = 0,
    ALPHABETIC = 1,
    ROMAN_NUMERALS = 2
}
Decorators.registerEnumType(EOptionDisplayTypes, 'GXpert.Web.Enums.EOptionDisplayTypes');