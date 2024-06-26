﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";
import { ActivationLogRow } from "./ActivationLogRow";

export interface ActivationLogColumns {
    Id: Column<ActivationLogRow>;
    Code: Column<ActivationLogRow>;
    SerialKey: Column<ActivationLogRow>;
    TeacherPrn: Column<ActivationLogRow>;
    PlayListTitle: Column<ActivationLogRow>;
    DeviceId: Column<ActivationLogRow>;
    DeviceDetails: Column<ActivationLogRow>;
    EStatus: Column<ActivationLogRow>;
    Note: Column<ActivationLogRow>;
}

export class ActivationLogColumns extends ColumnsBase<ActivationLogRow> {
    static readonly columnsKey = 'Activation.ActivationLog';
    static readonly Fields = fieldsProxy<ActivationLogColumns>();
}

[EKeyStatus]; // referenced types