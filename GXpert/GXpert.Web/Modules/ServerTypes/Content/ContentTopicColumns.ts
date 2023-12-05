import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentTopicRow } from "./ContentTopicRow";

export interface ContentTopicColumns {
    Id: Column<ContentTopicRow>;
    ContentTitle: Column<ContentTopicRow>;
    ClassTitle: Column<ContentTopicRow>;
    SubjectTitle: Column<ContentTopicRow>;
    TopicTitle: Column<ContentTopicRow>;
    MediumTitle: Column<ContentTopicRow>;
    SortOrder: Column<ContentTopicRow>;
    InsertDate: Column<ContentTopicRow>;
    InsertUserId: Column<ContentTopicRow>;
    UpdateDate: Column<ContentTopicRow>;
    UpdateUserId: Column<ContentTopicRow>;
    IsActive: Column<ContentTopicRow>;
}

export class ContentTopicColumns extends ColumnsBase<ContentTopicRow> {
    static readonly columnsKey = 'Content.ContentTopic';
    static readonly Fields = fieldsProxy<ContentTopicColumns>();
}