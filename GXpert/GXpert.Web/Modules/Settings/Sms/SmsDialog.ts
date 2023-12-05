import { SmsForm, SmsRow, SmsService } from '@/ServerTypes/Settings';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Settings.SmsDialog')
export class SmsDialog extends EntityDialog<SmsRow, any> {
    protected getFormKey() { return SmsForm.formKey; }
    protected getRowDefinition() { return SmsRow; }
    protected getService() { return SmsService.baseUrl; }

    protected form = new SmsForm(this.idPrefix);
}