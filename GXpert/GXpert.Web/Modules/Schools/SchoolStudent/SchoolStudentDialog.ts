import { SchoolStudentForm, SchoolStudentRow, SchoolStudentService } from '@/ServerTypes/Schools';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Schools.SchoolStudentDialog')
export class SchoolStudentDialog extends EntityDialog<SchoolStudentRow, any> {
    protected getFormKey() { return SchoolStudentForm.formKey; }
    protected getRowDefinition() { return SchoolStudentRow; }
    protected getService() { return SchoolStudentService.baseUrl; }

    protected form = new SchoolStudentForm(this.idPrefix);
}