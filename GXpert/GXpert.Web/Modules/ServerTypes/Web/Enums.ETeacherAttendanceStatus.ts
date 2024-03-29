import { Decorators } from "@serenity-is/corelib";

export enum ETeacherAttendanceStatus {
    Present = 0,
    Absent = 1,
    Assign_To_Other = 2
}
Decorators.registerEnumType(ETeacherAttendanceStatus, 'GXpert.Web.Enums.ETeacherAttendanceStatus');