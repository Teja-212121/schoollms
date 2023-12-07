import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { RaiseHandLiveSessionRow } from "./RaiseHandLiveSessionRow";

export interface RaiseHandLiveSessionColumns {
    Id: Column<RaiseHandLiveSessionRow>;
    LiveSessionlogId: Column<RaiseHandLiveSessionRow>;
    StudentPrn: Column<RaiseHandLiveSessionRow>;
    SessionTime: Column<RaiseHandLiveSessionRow>;
    HandRaiseStatus: Column<RaiseHandLiveSessionRow>;
    PlayListTitle: Column<RaiseHandLiveSessionRow>;
    ActivationDeviceId: Column<RaiseHandLiveSessionRow>;
    InsertDate: Column<RaiseHandLiveSessionRow>;
    InsertUserId: Column<RaiseHandLiveSessionRow>;
    UpdateDate: Column<RaiseHandLiveSessionRow>;
    UpdateUserId: Column<RaiseHandLiveSessionRow>;
    IsActive: Column<RaiseHandLiveSessionRow>;
}

export class RaiseHandLiveSessionColumns extends ColumnsBase<RaiseHandLiveSessionRow> {
    static readonly columnsKey = 'Attendance.RaiseHandLiveSession';
    static readonly Fields = fieldsProxy<RaiseHandLiveSessionColumns>();
}