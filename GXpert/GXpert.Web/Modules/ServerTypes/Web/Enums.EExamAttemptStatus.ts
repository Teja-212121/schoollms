import { Decorators } from "@serenity-is/corelib";

export enum EExamAttemptStatus {
    ASSIGNED = 0,
    STARTED = 1,
    UPLOADING = 2,
    UPLOADCOMPLETE = 3,
    TEACHERASSIGNED = 4,
    TEACHERACCEPTED = 5,
    TEACHERREJECTED = 6,
    ENDED = 7,
    RECHECK = 8
}
Decorators.registerEnumType(EExamAttemptStatus, 'GXpert.Web.Enums.EExamAttemptStatus');