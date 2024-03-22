import { InstituteTimeTableForm, InstituteTimeTableRow, InstituteTimeTableService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteTimeTableDialog')
export class InstituteTimeTableDialog extends EntityDialog<InstituteTimeTableRow, any> {
    protected getFormKey() { return InstituteTimeTableForm.formKey; }
    protected getRowDefinition() { return InstituteTimeTableRow; }
    protected getService() { return InstituteTimeTableService.baseUrl; }

    protected form = new InstituteTimeTableForm(this.idPrefix);
}