import { ExamQuestionForm, ExamQuestionRow, ExamQuestionService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.ExamQuestionDialog')
export class ExamQuestionDialog extends EntityDialog<ExamQuestionRow, any> {
    protected getFormKey() { return ExamQuestionForm.formKey; }
    protected getRowDefinition() { return ExamQuestionRow; }
    protected getService() { return ExamQuestionService.baseUrl; }

    protected form = new ExamQuestionForm(this.idPrefix);
}