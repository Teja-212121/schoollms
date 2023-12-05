import { ActivationForm, ActivationRow, ActivationService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.ActivationDialog')
export class ActivationDialog extends EntityDialog<ActivationRow, any> {
    protected getFormKey() { return ActivationForm.formKey; }
    protected getRowDefinition() { return ActivationRow; }
    protected getService() { return ActivationService.baseUrl; }

    protected form = new ActivationForm(this.idPrefix);
}