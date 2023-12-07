import { Decorators } from "@serenity-is/corelib";

export enum EAttemptStatus {
    ATTEMPTED = 0,
    NOTATTEMPTED = 1
}
Decorators.registerEnumType(EAttemptStatus, 'GXpert.Web.Enums.EAttemptStatus');