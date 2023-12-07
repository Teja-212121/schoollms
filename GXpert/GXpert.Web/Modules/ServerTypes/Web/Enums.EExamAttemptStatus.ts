import { Decorators } from "@serenity-is/corelib";

export enum EExamAttemptStatus {
    Assigned = 1,
    Started = 2,
    Uploading = 3,
    UploadComplete = 4,
    TeacherAssigned = 5,
    TeacherAccepted = 6,
    TeacherRejected = 7,
    Ended = 8,
    Recheck = 9
}
Decorators.registerEnumType(EExamAttemptStatus, 'GXpert.Web.Enums.EExamAttemptStatus');