import { ExamAttemptQuestionForm, ExamAttemptQuestionRow, ExamAttemptQuestionService } from '@/ServerTypes/Analytics';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Analytics.ExamAttemptQuestionDialog')
export class ExamAttemptQuestionDialog extends EntityDialog<ExamAttemptQuestionRow, any> {
    protected getFormKey() { return ExamAttemptQuestionForm.formKey; }
    protected getRowDefinition() { return ExamAttemptQuestionRow; }
    protected getService() { return ExamAttemptQuestionService.baseUrl; }

    protected form = new ExamAttemptQuestionForm(this.idPrefix);
}