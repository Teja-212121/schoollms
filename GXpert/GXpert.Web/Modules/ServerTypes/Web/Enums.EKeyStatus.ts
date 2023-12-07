import { Decorators } from "@serenity-is/corelib";

export enum EKeyStatus {
    CREATED = 0,
    OPEN = 1,
    ACTIVATED = 2,
    DISABLED = 3,
    EXPIRED = 4,
    OFFLINEACTIVATED = 5
}
Decorators.registerEnumType(EKeyStatus, 'GXpert.Web.Enums.EKeyStatus');