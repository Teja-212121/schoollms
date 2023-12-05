import { ExamForm, ExamRow, ExamService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.ExamDialog')
export class ExamDialog extends EntityDialog<ExamRow, any> {
    protected getFormKey() { return ExamForm.formKey; }
    protected getRowDefinition() { return ExamRow; }
    protected getService() { return ExamService.baseUrl; }

    protected form = new ExamForm(this.idPrefix);
}