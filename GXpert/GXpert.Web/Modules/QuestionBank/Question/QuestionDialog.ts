import { QuestionForm, QuestionRow, QuestionService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.QuestionBank.QuestionDialog')
export class QuestionDialog extends EntityDialog<QuestionRow, any> {
    protected getFormKey() { return QuestionForm.formKey; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    protected form = new QuestionForm(this.idPrefix);
}