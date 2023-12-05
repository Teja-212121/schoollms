import { ActivationLogForm, ActivationLogRow, ActivationLogService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.ActivationLogDialog')
export class ActivationLogDialog extends EntityDialog<ActivationLogRow, any> {
    protected getFormKey() { return ActivationLogForm.formKey; }
    protected getRowDefinition() { return ActivationLogRow; }
    protected getService() { return ActivationLogService.baseUrl; }

    protected form = new ActivationLogForm(this.idPrefix);
}