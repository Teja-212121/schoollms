import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentMediaRatingRow } from "./ContentMediaRatingRow";

export interface ContentMediaRatingColumns {
    Id: Column<ContentMediaRatingRow>;
    ContentTitle: Column<ContentMediaRatingRow>;
    RatingName: Column<ContentMediaRatingRow>;
    Score: Column<ContentMediaRatingRow>;
    Username: Column<ContentMediaRatingRow>;
    InsertDate: Column<ContentMediaRatingRow>;
    InsertUserId: Column<ContentMediaRatingRow>;
    UpdateDate: Column<ContentMediaRatingRow>;
    UpdateUserId: Column<ContentMediaRatingRow>;
    IsActive: Column<ContentMediaRatingRow>;
}

export class ContentMediaRatingColumns extends ColumnsBase<ContentMediaRatingRow> {
    static readonly columnsKey = 'Content.ContentMediaRating';
    static readonly Fields = fieldsProxy<ContentMediaRatingColumns>();
}