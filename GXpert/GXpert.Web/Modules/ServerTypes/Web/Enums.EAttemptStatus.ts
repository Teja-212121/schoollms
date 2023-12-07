import { Decorators } from "@serenity-is/corelib";

export enum EAttemptStatus {
    Attempted = 1,
    NotAttempted = 2
}
Decorators.registerEnumType(EAttemptStatus, 'GXpert.Web.Enums.EAttemptStatus');