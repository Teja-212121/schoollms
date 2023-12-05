import { TopicForm, TopicRow, TopicService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.TopicDialog')
export class TopicDialog extends EntityDialog<TopicRow, any> {
    protected getFormKey() { return TopicForm.formKey; }
    protected getRowDefinition() { return TopicRow; }
    protected getService() { return TopicService.baseUrl; }

    protected form = new TopicForm(this.idPrefix);
}