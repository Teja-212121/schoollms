import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EContentType } from "../Web/Enums.EContentType";
import { ContentRow } from "./ContentRow";

export interface ContentColumns {
    Id: Column<ContentRow>;
    Title: Column<ContentRow>;
    Description: Column<ContentRow>;
    EContentType: Column<ContentRow>;
    FileKeyUrl: Column<ContentRow>;
    Iv: Column<ContentRow>;
    FilePath: Column<ContentRow>;
    FilePathFallBack1: Column<ContentRow>;
    FilePathFallBack2: Column<ContentRow>;
    MediaInfo: Column<ContentRow>;
    ThumbNail: Column<ContentRow>;
    Poster: Column<ContentRow>;
    Length: Column<ContentRow>;
    Size: Column<ContentRow>;
    NumberOfPages: Column<ContentRow>;
    LikesCount: Column<ContentRow>;
    DisLikesCount: Column<ContentRow>;
    HandRaiseCount: Column<ContentRow>;
    SearchTags: Column<ContentRow>;
    EDifficultyLevel: Column<ContentRow>;
}

export class ContentColumns extends ColumnsBase<ContentRow> {
    static readonly columnsKey = 'Content.Content';
    static readonly Fields = fieldsProxy<ContentColumns>();
}

[EContentType]; // referenced types