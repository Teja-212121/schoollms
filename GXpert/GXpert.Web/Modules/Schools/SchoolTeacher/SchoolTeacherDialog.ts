import { SchoolTeacherForm, SchoolTeacherRow, SchoolTeacherService } from '@/ServerTypes/Schools';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Schools.SchoolTeacherDialog')
export class SchoolTeacherDialog extends EntityDialog<SchoolTeacherRow, any> {
    protected getFormKey() { return SchoolTeacherForm.formKey; }
    protected getRowDefinition() { return SchoolTeacherRow; }
    protected getService() { return SchoolTeacherService.baseUrl; }

    protected form = new SchoolTeacherForm(this.idPrefix);
}