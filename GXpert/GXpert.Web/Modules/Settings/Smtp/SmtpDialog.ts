import { SmtpForm, SmtpRow, SmtpService } from '@/ServerTypes/Settings';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Settings.SmtpDialog')
export class SmtpDialog extends EntityDialog<SmtpRow, any> {
    protected getFormKey() { return SmtpForm.formKey; }
    protected getRowDefinition() { return SmtpRow; }
    protected getService() { return SmtpService.baseUrl; }

    protected form = new SmtpForm(this.idPrefix);
}