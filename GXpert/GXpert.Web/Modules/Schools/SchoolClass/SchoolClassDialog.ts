import { SchoolClassForm, SchoolClassRow, SchoolClassService } from '@/ServerTypes/Schools';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Schools.SchoolClassDialog')
export class SchoolClassDialog extends EntityDialog<SchoolClassRow, any> {
    protected getFormKey() { return SchoolClassForm.formKey; }
    protected getRowDefinition() { return SchoolClassRow; }
    protected getService() { return SchoolClassService.baseUrl; }

    protected form = new SchoolClassForm(this.idPrefix);
}