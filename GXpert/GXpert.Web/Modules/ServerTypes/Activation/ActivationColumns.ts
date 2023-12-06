import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ActivationRow } from "./ActivationRow";

export interface ActivationColumns {
    Id: Column<ActivationRow>;
    PlayListTitle: Column<ActivationRow>;
    TeacherPrn: Column<ActivationRow>;
    ActivationLogCode: Column<ActivationRow>;
    DeviceId: Column<ActivationRow>;
    DeviceDetails: Column<ActivationRow>;
    ActivationDate: Column<ActivationRow>;
    ExpiryDate: Column<ActivationRow>;
    EStatus: Column<ActivationRow>;
}

export class ActivationColumns extends ColumnsBase<ActivationRow> {
    static readonly columnsKey = 'Activation.Activation';
    static readonly Fields = fieldsProxy<ActivationColumns>();
}