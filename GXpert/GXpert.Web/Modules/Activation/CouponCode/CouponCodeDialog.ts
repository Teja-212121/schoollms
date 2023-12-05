import { CouponCodeForm, CouponCodeRow, CouponCodeService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.CouponCodeDialog')
export class CouponCodeDialog extends EntityDialog<CouponCodeRow, any> {
    protected getFormKey() { return CouponCodeForm.formKey; }
    protected getRowDefinition() { return CouponCodeRow; }
    protected getService() { return CouponCodeService.baseUrl; }

    protected form = new CouponCodeForm(this.idPrefix);
}