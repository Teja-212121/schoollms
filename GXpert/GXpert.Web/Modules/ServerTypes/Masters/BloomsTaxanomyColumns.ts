﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BloomsTaxanomyRow } from "./BloomsTaxanomyRow";

export interface BloomsTaxanomyColumns {
    Id: Column<BloomsTaxanomyRow>;
    CoginitiveSkill: Column<BloomsTaxanomyRow>;
    SortOrder: Column<BloomsTaxanomyRow>;
}

export class BloomsTaxanomyColumns extends ColumnsBase<BloomsTaxanomyRow> {
    static readonly columnsKey = 'Masters.BloomsTaxanomy';
    static readonly Fields = fieldsProxy<BloomsTaxanomyColumns>();
}