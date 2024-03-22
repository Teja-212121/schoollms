import { PreAcademicForm, PreAcademicRow, PreAcademicService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.PreAcademicDialog')
export class PreAcademicDialog extends EntityDialog<PreAcademicRow, any> {
    protected getFormKey() { return PreAcademicForm.formKey; }
    protected getRowDefinition() { return PreAcademicRow; }
    protected getService() { return PreAcademicService.baseUrl; }

    protected form = new PreAcademicForm(this.idPrefix);
}