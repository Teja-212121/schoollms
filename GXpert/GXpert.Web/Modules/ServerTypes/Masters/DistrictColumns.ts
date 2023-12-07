import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DistrictRow } from "./DistrictRow";

export interface DistrictColumns {
    Id: Column<DistrictRow>;
    Title: Column<DistrictRow>;
    StateTitle: Column<DistrictRow>;
    ShortName: Column<DistrictRow>;
}

export class DistrictColumns extends ColumnsBase<DistrictRow> {
    static readonly columnsKey = 'Masters.District';
    static readonly Fields = fieldsProxy<DistrictColumns>();
}