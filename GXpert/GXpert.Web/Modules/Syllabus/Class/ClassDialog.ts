import { ClassForm, ClassRow, ClassService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.ClassDialog')
export class ClassDialog extends EntityDialog<ClassRow, any> {
    protected getFormKey() { return ClassForm.formKey; }
    protected getRowDefinition() { return ClassRow; }
    protected getService() { return ClassService.baseUrl; }

    protected form = new ClassForm(this.idPrefix);
}