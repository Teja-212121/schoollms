import { InstituteForm, InstituteRow, InstituteService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteDialog')
export class InstituteDialog extends EntityDialog<InstituteRow, any> {
    protected getFormKey() { return InstituteForm.formKey; }
    protected getRowDefinition() { return InstituteRow; }
    protected getService() { return InstituteService.baseUrl; }

    protected form = new InstituteForm(this.idPrefix);
}