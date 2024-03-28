import { QuestionCourseForm, QuestionCourseRow, QuestionCourseService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.QuestionBank.QuestionCourseDialog')
export class QuestionCourseDialog extends EntityDialog<QuestionCourseRow, any> {
    protected getFormKey() { return QuestionCourseForm.formKey; }
    protected getRowDefinition() { return QuestionCourseRow; }
    protected getService() { return QuestionCourseService.baseUrl; }

    protected form = new QuestionCourseForm(this.idPrefix);
}