import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TenantRow } from "./TenantRow";

export interface TenantColumns {
    TenantId: Column<TenantRow>;
    TenantName: Column<TenantRow>;
    OwnerId: Column<TenantRow>;
}

export class TenantColumns extends ColumnsBase<TenantRow> {
    static readonly columnsKey = 'Administration.Tenant';
    static readonly Fields = fieldsProxy<TenantColumns>();
}