import { ExamSectionForm, ExamSectionRow, ExamSectionService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.ExamSectionDialog')
export class ExamSectionDialog extends EntityDialog<ExamSectionRow, any> {
    protected getFormKey() { return ExamSectionForm.formKey; }
    protected getRowDefinition() { return ExamSectionRow; }
    protected getService() { return ExamSectionService.baseUrl; }

    protected form = new ExamSectionForm(this.idPrefix);
}