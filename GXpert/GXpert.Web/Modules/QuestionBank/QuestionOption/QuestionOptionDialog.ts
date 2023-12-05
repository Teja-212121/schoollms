import { QuestionOptionForm, QuestionOptionRow, QuestionOptionService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.QuestionBank.QuestionOptionDialog')
export class QuestionOptionDialog extends EntityDialog<QuestionOptionRow, any> {
    protected getFormKey() { return QuestionOptionForm.formKey; }
    protected getRowDefinition() { return QuestionOptionRow; }
    protected getService() { return QuestionOptionService.baseUrl; }

    protected form = new QuestionOptionForm(this.idPrefix);
}