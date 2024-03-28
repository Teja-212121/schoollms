import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentAudioRow } from "./ContentAudioRow";

export interface ContentAudioColumns {
    Id: Column<ContentAudioRow>;
    MediaFile: Column<ContentAudioRow>;
    HlsFile: Column<ContentAudioRow>;
    FileKeyUrl: Column<ContentAudioRow>;
    Iv: Column<ContentAudioRow>;
    ContentTitle: Column<ContentAudioRow>;
    LanguageName: Column<ContentAudioRow>;
    Username: Column<ContentAudioRow>;
}

export class ContentAudioColumns extends ColumnsBase<ContentAudioRow> {
    static readonly columnsKey = 'Content.ContentAudio';
    static readonly Fields = fieldsProxy<ContentAudioColumns>();
}