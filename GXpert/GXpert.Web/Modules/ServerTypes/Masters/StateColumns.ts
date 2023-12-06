import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { StateRow } from "./StateRow";

export interface StateColumns {
    Id: Column<StateRow>;
    Title: Column<StateRow>;
    ShortName: Column<StateRow>;
}

export class StateColumns extends ColumnsBase<StateRow> {
    static readonly columnsKey = 'Masters.State';
    static readonly Fields = fieldsProxy<StateColumns>();
}