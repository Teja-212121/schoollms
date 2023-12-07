import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CouponCodeRow } from "./CouponCodeRow";

export interface CouponCodeColumns {
    Id: Column<CouponCodeRow>;
    Code: Column<CouponCodeRow>;
    PlayListTitle: Column<CouponCodeRow>;
    ValidityType: Column<CouponCodeRow>;
    CountType: Column<CouponCodeRow>;
    Count: Column<CouponCodeRow>;
    ValidityInDays: Column<CouponCodeRow>;
    ValidDate: Column<CouponCodeRow>;
    ConsumedCount: Column<CouponCodeRow>;
    CouponValidityDate: Column<CouponCodeRow>;
    InsertDate: Column<CouponCodeRow>;
    InsertUserId: Column<CouponCodeRow>;
    UpdateDate: Column<CouponCodeRow>;
    UpdateUserId: Column<CouponCodeRow>;
    IsActive: Column<CouponCodeRow>;
}

export class CouponCodeColumns extends ColumnsBase<CouponCodeRow> {
    static readonly columnsKey = 'Activation.CouponCode';
    static readonly Fields = fieldsProxy<CouponCodeColumns>();
}