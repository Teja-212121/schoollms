import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentCommentRow } from "./ContentCommentRow";

export interface ContentCommentColumns {
    Id: Column<ContentCommentRow>;
    CommentText: Column<ContentCommentRow>;
    CommentLeft: Column<ContentCommentRow>;
    CommentRight: Column<ContentCommentRow>;
    TreeId: Column<ContentCommentRow>;
    CommentLevel: Column<ContentCommentRow>;
    ParentCommentText: Column<ContentCommentRow>;
    ContentTitle: Column<ContentCommentRow>;
    Username: Column<ContentCommentRow>;
    InsertDate: Column<ContentCommentRow>;
    InsertUserId: Column<ContentCommentRow>;
    UpdateDate: Column<ContentCommentRow>;
    UpdateUserId: Column<ContentCommentRow>;
    IsActive: Column<ContentCommentRow>;
}

export class ContentCommentColumns extends ColumnsBase<ContentCommentRow> {
    static readonly columnsKey = 'Content.ContentComment';
    static readonly Fields = fieldsProxy<ContentCommentColumns>();
}