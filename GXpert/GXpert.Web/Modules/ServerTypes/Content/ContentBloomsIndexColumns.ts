﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentBloomsIndexRow } from "./ContentBloomsIndexRow";

export interface ContentBloomsIndexColumns {
    Id: Column<ContentBloomsIndexRow>;
    ContentTitle: Column<ContentBloomsIndexRow>;
    BloomsIndexCoginitiveSkill: Column<ContentBloomsIndexRow>;
    Weightage: Column<ContentBloomsIndexRow>;
}

export class ContentBloomsIndexColumns extends ColumnsBase<ContentBloomsIndexRow> {
    static readonly columnsKey = 'Content.ContentBloomsIndex';
    static readonly Fields = fieldsProxy<ContentBloomsIndexColumns>();
}