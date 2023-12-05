import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PlayListcontentRow } from "./PlayListcontentRow";

export interface PlayListcontentColumns {
    Id: Column<PlayListcontentRow>;
    PlayListTitle: Column<PlayListcontentRow>;
    ContentTitle: Column<PlayListcontentRow>;
    ExamTitle: Column<PlayListcontentRow>;
    LiveSessionMeetingId: Column<PlayListcontentRow>;
    AssignmentTitle: Column<PlayListcontentRow>;
    ModuleTitle: Column<PlayListcontentRow>;
    SortOrder: Column<PlayListcontentRow>;
    EPublishStatus: Column<PlayListcontentRow>;
    InsertDate: Column<PlayListcontentRow>;
    InsertUserId: Column<PlayListcontentRow>;
    UpdateDate: Column<PlayListcontentRow>;
    UpdateUserId: Column<PlayListcontentRow>;
    IsActive: Column<PlayListcontentRow>;
}

export class PlayListcontentColumns extends ColumnsBase<PlayListcontentRow> {
    static readonly columnsKey = 'Playlist.PlayListcontent';
    static readonly Fields = fieldsProxy<PlayListcontentColumns>();
}