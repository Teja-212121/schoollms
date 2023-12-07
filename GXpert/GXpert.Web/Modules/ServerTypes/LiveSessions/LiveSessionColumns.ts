import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ELiveProvider } from "../Web/Enums.ELiveProvider";
import { LiveSessionRow } from "./LiveSessionRow";

export interface LiveSessionColumns {
    Id: Column<LiveSessionRow>;
    MeetingId: Column<LiveSessionRow>;
    LiveProvider: Column<LiveSessionRow>;
    Password: Column<LiveSessionRow>;
    Secret: Column<LiveSessionRow>;
    LiveAdditionalInfo: Column<LiveSessionRow>;
    SearchTags: Column<LiveSessionRow>;
}

export class LiveSessionColumns extends ColumnsBase<LiveSessionRow> {
    static readonly columnsKey = 'LiveSessions.LiveSession';
    static readonly Fields = fieldsProxy<LiveSessionColumns>();
}

[ELiveProvider]; // referenced types