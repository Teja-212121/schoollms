import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LiveSessionLogRow } from "./LiveSessionLogRow";

export interface LiveSessionLogColumns {
    Id: Column<LiveSessionLogRow>;
    Date: Column<LiveSessionLogRow>;
    StartTime: Column<LiveSessionLogRow>;
    EndTime: Column<LiveSessionLogRow>;
    TeacherPrn: Column<LiveSessionLogRow>;
    ClassTitle: Column<LiveSessionLogRow>;
    SubjectTitle: Column<LiveSessionLogRow>;
    InsertDate: Column<LiveSessionLogRow>;
    InsertUserId: Column<LiveSessionLogRow>;
    UpdateDate: Column<LiveSessionLogRow>;
    UpdateUserId: Column<LiveSessionLogRow>;
    IsActive: Column<LiveSessionLogRow>;
}

export class LiveSessionLogColumns extends ColumnsBase<LiveSessionLogRow> {
    static readonly columnsKey = 'LiveSessions.LiveSessionLog';
    static readonly Fields = fieldsProxy<LiveSessionLogColumns>();
}