import { Decorators } from "@serenity-is/corelib";

export enum ELiveProvider {
    ZOOM = 0,
    OVEN = 1
}
Decorators.registerEnumType(ELiveProvider, 'GXpert.Web.Enums.ELiveProvider');