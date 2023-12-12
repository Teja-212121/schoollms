import { CouponCodeForm, CouponCodeRow, CouponCodeService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog, isEmptyOrNull } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.CouponCodeDialog')
export class CouponCodeDialog extends EntityDialog<CouponCodeRow, any> {
    protected getFormKey() { return CouponCodeForm.formKey; }
    protected getRowDefinition() { return CouponCodeRow; }
    protected getService() { return CouponCodeService.baseUrl; }

    protected form = new CouponCodeForm(this.idPrefix);

    constructor() {
        super();
        this.form.ValidityType.change(e => {
            var vValidityType = this.form.ValidityType.value;

            if (isEmptyOrNull(vValidityType)) {
                this.form.ValidDate.getGridField().toggle(false);
                this.form.ValidityInDays.getGridField().toggle(false);
            }
            else {

                if (vValidityType == '0' || vValidityType == '1' || vValidityType == '2') {

                    if (vValidityType == '0') {
                        this.form.ValidDate.getGridField().toggle(false);
                        this.form.ValidityInDays.getGridField().toggle(false);
                    }
                    else if (vValidityType == '1') {
                        this.form.ValidDate.getGridField().toggle(true);
                        this.form.ValidityInDays.getGridField().toggle(false);
                    }
                    else {
                        this.form.ValidDate.getGridField().toggle(false);
                        this.form.ValidityInDays.getGridField().toggle(true);
                    }
                }
            }
        });

        this.form.CountType.change(e => {
            var vCountType = this.form.CountType.value;

            if (isEmptyOrNull(vCountType)) {
                this.form.Count.getGridField().toggle(false);
            }
            else {

                if (vCountType == '0' || vCountType == '1') {

                    if (vCountType == '0') {
                        this.form.Count.getGridField().toggle(false);
                    }
                    else {
                        this.form.Count.getGridField().toggle(true);
                    }
                }
            }
        });
    }
}