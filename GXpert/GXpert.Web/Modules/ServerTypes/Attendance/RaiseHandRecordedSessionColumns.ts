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
    InsertDate: Column<RaiseHandRecordedSessionRow>;
    InsertUserId: Column<RaiseHandRecordedSessionRow>;
    UpdateDate: Column<RaiseHandRecordedSessionRow>;
    UpdateUserId: Column<RaiseHandRecordedSessionRow>;
    IsActive: Column<RaiseHandRecordedSessionRow>;
}

export class RaiseHandRecordedSessionColumns extends ColumnsBase<RaiseHandRecordedSessionRow> {
    static readonly columnsKey = 'Attendance.RaiseHandRecordedSession';
    static readonly Fields = fieldsProxy<RaiseHandRecordedSessionColumns>();
}