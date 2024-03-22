import { PrincipalForm, PrincipalRow, PrincipalService } from '@/ServerTypes/Users';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Users.PrincipalDialog')
export class PrincipalDialog extends EntityDialog<PrincipalRow, any> {
    protected getFormKey() { return PrincipalForm.formKey; }
    protected getRowDefinition() { return PrincipalRow; }
    protected getService() { return PrincipalService.baseUrl; }

    protected form = new PrincipalForm(this.idPrefix);
}