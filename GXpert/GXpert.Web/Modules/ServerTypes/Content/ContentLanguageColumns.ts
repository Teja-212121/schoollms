import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentLanguageRow } from "./ContentLanguageRow";

export interface ContentLanguageColumns {
    Id: Column<ContentLanguageRow>;
    Name: Column<ContentLanguageRow>;
    Description: Column<ContentLanguageRow>;
}

export class ContentLanguageColumns extends ColumnsBase<ContentLanguageRow> {
    static readonly columnsKey = 'Content.ContentLanguage';
    static readonly Fields = fieldsProxy<ContentLanguageColumns>();
}