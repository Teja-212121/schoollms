import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TalukaRow } from "./TalukaRow";

export interface TalukaColumns {
    Id: Column<TalukaRow>;
    Title: Column<TalukaRow>;
    StateTitle: Column<TalukaRow>;
    DistrictTitle: Column<TalukaRow>;
    ShortName: Column<TalukaRow>;
}

export class TalukaColumns extends ColumnsBase<TalukaRow> {
    static readonly columnsKey = 'Masters.Taluka';
    static readonly Fields = fieldsProxy<TalukaColumns>();
}