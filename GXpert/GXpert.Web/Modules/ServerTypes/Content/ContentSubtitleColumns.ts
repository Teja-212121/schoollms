import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentSubtitleRow } from "./ContentSubtitleRow";

export interface ContentSubtitleColumns {
    Id: Column<ContentSubtitleRow>;
    SubtitleFile: Column<ContentSubtitleRow>;
    ContentTitle: Column<ContentSubtitleRow>;
    LanguageName: Column<ContentSubtitleRow>;
    Username: Column<ContentSubtitleRow>;
}

export class ContentSubtitleColumns extends ColumnsBase<ContentSubtitleRow> {
    static readonly columnsKey = 'Content.ContentSubtitle';
    static readonly Fields = fieldsProxy<ContentSubtitleColumns>();
}