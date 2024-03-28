import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentRatingRow } from "./ContentRatingRow";

export interface ContentRatingColumns {
    Id: Column<ContentRatingRow>;
    Name: Column<ContentRatingRow>;
    Description: Column<ContentRatingRow>;
}

export class ContentRatingColumns extends ColumnsBase<ContentRatingRow> {
    static readonly columnsKey = 'Content.ContentRating';
    static readonly Fields = fieldsProxy<ContentRatingColumns>();
}