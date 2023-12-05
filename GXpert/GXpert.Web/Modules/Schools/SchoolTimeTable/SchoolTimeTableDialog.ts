import { SchoolTimeTableForm, SchoolTimeTableRow, SchoolTimeTableService } from '@/ServerTypes/Schools';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Schools.SchoolTimeTableDialog')
export class SchoolTimeTableDialog extends EntityDialog<SchoolTimeTableRow, any> {
    protected getFormKey() { return SchoolTimeTableForm.formKey; }
    protected getRowDefinition() { return SchoolTimeTableRow; }
    protected getService() { return SchoolTimeTableService.baseUrl; }

    protected form = new SchoolTimeTableForm(this.idPrefix);
}