import { NotificationForm, NotificationRow, NotificationService } from '@/ServerTypes/Settings';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Settings.NotificationDialog')
export class NotificationDialog extends EntityDialog<NotificationRow, any> {
    protected getFormKey() { return NotificationForm.formKey; }
    protected getRowDefinition() { return NotificationRow; }
    protected getService() { return NotificationService.baseUrl; }

    protected form = new NotificationForm(this.idPrefix);
}