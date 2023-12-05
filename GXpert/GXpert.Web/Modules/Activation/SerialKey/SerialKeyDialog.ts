import { SerialKeyForm, SerialKeyRow, SerialKeyService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.SerialKeyDialog')
export class SerialKeyDialog extends EntityDialog<SerialKeyRow, any> {
    protected getFormKey() { return SerialKeyForm.formKey; }
    protected getRowDefinition() { return SerialKeyRow; }
    protected getService() { return SerialKeyService.baseUrl; }

    protected form = new SerialKeyForm(this.idPrefix);
}