import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PlayListRow } from "./PlayListRow";

export interface PlayListColumns {
    Id: Column<PlayListRow>;
    Title: Column<PlayListRow>;
    Description: Column<PlayListRow>;
    ClassTitle: Column<PlayListRow>;
    SubjectTitle: Column<PlayListRow>;
    TeacherPrn: Column<PlayListRow>;
}

export class PlayListColumns extends ColumnsBase<PlayListRow> {
    static readonly columnsKey = 'Playlist.PlayList';
    static readonly Fields = fieldsProxy<PlayListColumns>();
}