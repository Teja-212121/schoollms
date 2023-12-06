import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { MediumRow } from "./MediumRow";

export interface MediumColumns {
    Id: Column<MediumRow>;
    Title: Column<MediumRow>;
    Description: Column<MediumRow>;
}

export class MediumColumns extends ColumnsBase<MediumRow> {
    static readonly columnsKey = 'Syllabus.Medium';
    static readonly Fields = fieldsProxy<MediumColumns>();
}