import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CommonDataRow } from "./CommonDataRow";

export interface CommonDataColumns {
    Id: Column<CommonDataRow>;
    CommonDataTitle: Column<CommonDataRow>;
    CommonData: Column<CommonDataRow>;
    InsertDate: Column<CommonDataRow>;
    InsertUserId: Column<CommonDataRow>;
    UpdateDate: Column<CommonDataRow>;
    UpdateUserId: Column<CommonDataRow>;
    IsActive: Column<CommonDataRow>;
}

export class CommonDataColumns extends ColumnsBase<CommonDataRow> {
    static readonly columnsKey = 'QuestionBank.CommonData';
    static readonly Fields = fieldsProxy<CommonDataColumns>();
}