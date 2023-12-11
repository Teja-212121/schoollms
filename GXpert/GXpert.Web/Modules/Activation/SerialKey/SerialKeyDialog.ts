import { SerialKeyForm, SerialKeyRow, SerialKeyService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog, isEmptyOrNull } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.SerialKeyDialog')
export class SerialKeyDialog extends EntityDialog<SerialKeyRow, any> {
    protected getFormKey() { return SerialKeyForm.formKey; }
    protected getRowDefinition() { return SerialKeyRow; }
    protected getService() { return SerialKeyService.baseUrl; }

    protected form = new SerialKeyForm(this.idPrefix);

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
    }
}