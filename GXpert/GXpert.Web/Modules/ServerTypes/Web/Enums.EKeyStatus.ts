import { Decorators } from "@serenity-is/corelib";

export enum EKeyStatus {
    Created = 1,
    Open = 2,
    Activated = 3,
    Disabled = 4,
    Expired = 5,
    OfflineActivated = 6
}
Decorators.registerEnumType(EKeyStatus, 'GXpert.Web.Enums.EKeyStatus');