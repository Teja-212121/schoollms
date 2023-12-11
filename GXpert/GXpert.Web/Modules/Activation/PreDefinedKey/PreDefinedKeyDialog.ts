import { PreDefinedKeyForm, PreDefinedKeyRow, PreDefinedKeyService } from '@/ServerTypes/Activation';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Activation.PreDefinedKeyDialog')
export class PreDefinedKeyDialog extends EntityDialog<PreDefinedKeyRow, any> {
    protected getFormKey() { return PreDefinedKeyForm.formKey; }
    protected getRowDefinition() { return PreDefinedKeyRow; }
    protected getService() { return PreDefinedKeyService.baseUrl; }

    protected form = new PreDefinedKeyForm(this.idPrefix);
}