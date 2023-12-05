import { SubjectForm, SubjectRow, SubjectService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.SubjectDialog')
export class SubjectDialog extends EntityDialog<SubjectRow, any> {
    protected getFormKey() { return SubjectForm.formKey; }
    protected getRowDefinition() { return SubjectRow; }
    protected getService() { return SubjectService.baseUrl; }

    protected form = new SubjectForm(this.idPrefix);
}