import { Decorators } from "@serenity-is/corelib";

export enum EPreDefinedKeyStatus {
    OPEN = 0,
    CREATED = 1
}
Decorators.registerEnumType(EPreDefinedKeyStatus, 'Rio.Web.Enums.EPreDefinedKeyStatus');