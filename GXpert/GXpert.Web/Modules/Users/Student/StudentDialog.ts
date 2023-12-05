import { StudentForm, StudentRow, StudentService } from '@/ServerTypes/Users';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Users.StudentDialog')
export class StudentDialog extends EntityDialog<StudentRow, any> {
    protected getFormKey() { return StudentForm.formKey; }
    protected getRowDefinition() { return StudentRow; }
    protected getService() { return StudentService.baseUrl; }

    protected form = new StudentForm(this.idPrefix);
}