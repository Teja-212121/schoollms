import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EPreDefinedKeyStatus } from "../Rio/Web.Enums.EPreDefinedKeyStatus";
import { PreDefinedKeyRow } from "./PreDefinedKeyRow";

export interface PreDefinedKeyColumns {
    Id: Column<PreDefinedKeyRow>;
    SerialKey: Column<PreDefinedKeyRow>;
    EStatus: Column<PreDefinedKeyRow>;
    InsertDate: Column<PreDefinedKeyRow>;
    InsertUserId: Column<PreDefinedKeyRow>;
    UpdateDate: Column<PreDefinedKeyRow>;
    UpdateUserId: Column<PreDefinedKeyRow>;
    IsActive: Column<PreDefinedKeyRow>;
}

export class PreDefinedKeyColumns extends ColumnsBase<PreDefinedKeyRow> {
    static readonly columnsKey = 'Activation.PreDefinedKey';
    static readonly Fields = fieldsProxy<PreDefinedKeyColumns>();
}

[EPreDefinedKeyStatus]; // referenced types