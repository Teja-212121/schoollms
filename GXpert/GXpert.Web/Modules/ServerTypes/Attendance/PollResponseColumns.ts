import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PollResponseRow } from "./PollResponseRow";

export interface PollResponseColumns {
    Id: Column<PollResponseRow>;
    PollQuestion: Column<PollResponseRow>;
    StudentPrn: Column<PollResponseRow>;
    Response: Column<PollResponseRow>;
    ResponseTimeInSeconds: Column<PollResponseRow>;
    Score: Column<PollResponseRow>;
    LiveSessionLogId: Column<PollResponseRow>;
    ActivationDeviceId: Column<PollResponseRow>;
    InsertDate: Column<PollResponseRow>;
    InsertUserId: Column<PollResponseRow>;
    UpdateDate: Column<PollResponseRow>;
    UpdateUserId: Column<PollResponseRow>;
    IsActive: Column<PollResponseRow>;
}

export class PollResponseColumns extends ColumnsBase<PollResponseRow> {
    static readonly columnsKey = 'Attendance.PollResponse';
    static readonly Fields = fieldsProxy<PollResponseColumns>();
}