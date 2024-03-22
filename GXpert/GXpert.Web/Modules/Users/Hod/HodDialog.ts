import { HodForm, HodRow, HodService } from '@/ServerTypes/Users';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Users.HodDialog')
export class HodDialog extends EntityDialog<HodRow, any> {
    protected getFormKey() { return HodForm.formKey; }
    protected getRowDefinition() { return HodRow; }
    protected getService() { return HodService.baseUrl; }

    protected form = new HodForm(this.idPrefix);
}