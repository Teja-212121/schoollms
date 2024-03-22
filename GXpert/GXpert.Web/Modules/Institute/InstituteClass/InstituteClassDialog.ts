import { InstituteClassForm, InstituteClassRow, InstituteClassService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteClassDialog')
export class InstituteClassDialog extends EntityDialog<InstituteClassRow, any> {
    protected getFormKey() { return InstituteClassForm.formKey; }
    protected getRowDefinition() { return InstituteClassRow; }
    protected getService() { return InstituteClassService.baseUrl; }

    protected form = new InstituteClassForm(this.idPrefix);
}