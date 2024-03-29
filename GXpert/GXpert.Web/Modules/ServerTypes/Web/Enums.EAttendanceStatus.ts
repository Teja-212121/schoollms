import { Decorators } from "@serenity-is/corelib";

export enum EAttendanceStatus {
    Present = 0,
    Absent = 1
}
Decorators.registerEnumType(EAttendanceStatus, 'GXpert.Web.Enums.EAttendanceStatus');