import { CouponCodeColumns, CouponCodeRow, CouponCodeService } from '@/ServerTypes/Activation';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CouponCodeDialog } from './CouponCodeDialog';

@Decorators.registerClass('GXpert.Activation.CouponCodeGrid')
export class CouponCodeGrid extends EntityGrid<CouponCodeRow, any> {
    protected getColumnsKey() { return CouponCodeColumns.columnsKey; }
    protected getDialogType() { return CouponCodeDialog; }
    protected getRowDefinition() { return CouponCodeRow; }
    protected getService() { return CouponCodeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}