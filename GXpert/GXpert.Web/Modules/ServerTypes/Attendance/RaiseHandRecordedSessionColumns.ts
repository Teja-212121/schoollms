import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { RaiseHandRecordedSessionRow } from "./RaiseHandRecordedSessionRow";

export interface RaiseHandRecordedSessionColumns {
    Id: Column<RaiseHandRecordedSessionRow>;
    ContentTitle: Column<RaiseHandRecordedSessionRow>;
    StudentPrn: Column<RaiseHandRecordedSessionRow>;
    PlayListTitle: Column<RaiseHandRecordedSessionRow>;
    PlayListContentId: Column<RaiseHandRecordedSessionRow>;
    ActivationDeviceId: Column<RaiseHandRecordedSessionRow>;
}

export class RaiseHandRecordedSessionColumns extends ColumnsBase<RaiseHandRecordedSessionRow> {
    static readonly columnsKey = 'Attendance.RaiseHandRecordedSession';
    static readonly Fields = fieldsProxy<RaiseHandRecordedSessionColumns>();
}