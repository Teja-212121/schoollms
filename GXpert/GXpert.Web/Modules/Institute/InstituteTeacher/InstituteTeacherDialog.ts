import { InstituteTeacherForm, InstituteTeacherRow, InstituteTeacherService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteTeacherDialog')
export class InstituteTeacherDialog extends EntityDialog<InstituteTeacherRow, any> {
    protected getFormKey() { return InstituteTeacherForm.formKey; }
    protected getRowDefinition() { return InstituteTeacherRow; }
    protected getService() { return InstituteTeacherService.baseUrl; }

    protected form = new InstituteTeacherForm(this.idPrefix);
}