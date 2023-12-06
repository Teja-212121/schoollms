import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TopicRow } from "./TopicRow";

export interface TopicColumns {
    Id: Column<TopicRow>;
    Title: Column<TopicRow>;
    Description: Column<TopicRow>;
    SortOrder: Column<TopicRow>;
    ClassTitle: Column<TopicRow>;
    MediumTitle: Column<TopicRow>;
    SubjectTitle: Column<TopicRow>;
    Weightage: Column<TopicRow>;
    Thumbnail: Column<TopicRow>;
}

export class TopicColumns extends ColumnsBase<TopicRow> {
    static readonly columnsKey = 'Syllabus.Topic';
    static readonly Fields = fieldsProxy<TopicColumns>();
}