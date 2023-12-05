import { ContentTopicForm, ContentTopicRow, ContentTopicService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentTopicDialog')
export class ContentTopicDialog extends EntityDialog<ContentTopicRow, any> {
    protected getFormKey() { return ContentTopicForm.formKey; }
    protected getRowDefinition() { return ContentTopicRow; }
    protected getService() { return ContentTopicService.baseUrl; }

    protected form = new ContentTopicForm(this.idPrefix);
}