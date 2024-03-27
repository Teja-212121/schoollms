import { InstituteStudentForm, InstituteStudentRow, InstituteStudentService } from '@/ServerTypes/Institute';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteStudentDialog')
export class InstituteStudentDialog extends EntityDialog<InstituteStudentRow, any> {
    protected getFormKey() { return InstituteStudentForm.formKey; }
    protected getRowDefinition() { return InstituteStudentRow; }
    protected getService() { return InstituteStudentService.baseUrl; }

    protected form = new InstituteStudentForm(this.idPrefix);
    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.StudentId, true);
    }
}