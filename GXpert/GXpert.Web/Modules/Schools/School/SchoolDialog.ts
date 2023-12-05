import { SchoolForm, SchoolRow, SchoolService } from '@/ServerTypes/Schools';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Schools.SchoolDialog')
export class SchoolDialog extends EntityDialog<SchoolRow, any> {
    protected getFormKey() { return SchoolForm.formKey; }
    protected getRowDefinition() { return SchoolRow; }
    protected getService() { return SchoolService.baseUrl; }

    protected form = new SchoolForm(this.idPrefix);
}