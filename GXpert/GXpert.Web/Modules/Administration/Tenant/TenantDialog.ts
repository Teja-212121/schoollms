import { TenantForm, TenantRow, TenantService } from '@/ServerTypes/Administration';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Administration.TenantDialog')
export class TenantDialog extends EntityDialog<TenantRow, any> {
    protected getFormKey() { return TenantForm.formKey; }
    protected getRowDefinition() { return TenantRow; }
    protected getService() { return TenantService.baseUrl; }

    protected form = new TenantForm(this.idPrefix);
}