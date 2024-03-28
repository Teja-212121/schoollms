import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentCategoryRow } from "./ContentCategoryRow";

export interface ContentCategoryColumns {
    Id: Column<ContentCategoryRow>;
    Name: Column<ContentCategoryRow>;
    Description: Column<ContentCategoryRow>;
    IsGlobal: Column<ContentCategoryRow>;
    MediaCount: Column<ContentCategoryRow>;
    Thumbnail: Column<ContentCategoryRow>;
    ListingThumbnail: Column<ContentCategoryRow>;
}

export class ContentCategoryColumns extends ColumnsBase<ContentCategoryRow> {
    static readonly columnsKey = 'Content.ContentCategory';
    static readonly Fields = fieldsProxy<ContentCategoryColumns>();
}