import { TeacherForm, TeacherRow, TeacherService } from '@/ServerTypes/Users';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Users.TeacherDialog')
export class TeacherDialog extends EntityDialog<TeacherRow, any> {
    protected getFormKey() { return TeacherForm.formKey; }
    protected getRowDefinition() { return TeacherRow; }
    protected getService() { return TeacherService.baseUrl; }

    protected form = new TeacherForm(this.idPrefix);
}