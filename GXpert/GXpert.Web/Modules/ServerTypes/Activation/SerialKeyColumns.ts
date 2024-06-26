﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EValidityType } from "../Web/Enums.EValidityType";
import { SerialKeyRow } from "./SerialKeyRow";

export interface SerialKeyColumns {
    Id: Column<SerialKeyRow>;
    SerialKey: Column<SerialKeyRow>;
    PlayListTitle: Column<SerialKeyRow>;
    ValidityType: Column<SerialKeyRow>;
    ValidityInDays: Column<SerialKeyRow>;
    ValidDate: Column<SerialKeyRow>;
    Note: Column<SerialKeyRow>;
    EStatus: Column<SerialKeyRow>;
}

export class SerialKeyColumns extends ColumnsBase<SerialKeyRow> {
    static readonly columnsKey = 'Activation.SerialKey';
    static readonly Fields = fieldsProxy<SerialKeyColumns>();
}

[EValidityType]; // referenced types