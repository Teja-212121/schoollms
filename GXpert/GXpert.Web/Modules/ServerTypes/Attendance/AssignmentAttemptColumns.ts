import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AssignmentAttemptRow } from "./AssignmentAttemptRow";

export interface AssignmentAttemptColumns {
    Id: Column<AssignmentAttemptRow>;
    AssignmentTitle: Column<AssignmentAttemptRow>;
    StudentPrn: Column<AssignmentAttemptRow>;
    FileUploaded: Column<AssignmentAttemptRow>;
    EStatus: Column<AssignmentAttemptRow>;
    TeacherPrn: Column<AssignmentAttemptRow>;
    PlayListTitle: Column<AssignmentAttemptRow>;
    ActivationDeviceId: Column<AssignmentAttemptRow>;
    InsertDate: Column<AssignmentAttemptRow>;
    InsertUserId: Column<AssignmentAttemptRow>;
    UpdateDate: Column<AssignmentAttemptRow>;
    UpdateUserId: Column<AssignmentAttemptRow>;
    IsActive: Column<AssignmentAttemptRow>;
}

export class AssignmentAttemptColumns extends ColumnsBase<AssignmentAttemptRow> {
    static readonly columnsKey = 'Attendance.AssignmentAttempt';
    static readonly Fields = fieldsProxy<AssignmentAttemptColumns>();
}