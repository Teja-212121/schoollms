import { ExamAttemptForm, ExamAttemptRow, ExamAttemptService } from '@/ServerTypes/Analytics';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Analytics.ExamAttemptDialog')
export class ExamAttemptDialog extends EntityDialog<ExamAttemptRow, any> {
    protected getFormKey() { return ExamAttemptForm.formKey; }
    protected getRowDefinition() { return ExamAttemptRow; }
    protected getService() { return ExamAttemptService.baseUrl; }

    protected form = new ExamAttemptForm(this.idPrefix);
}