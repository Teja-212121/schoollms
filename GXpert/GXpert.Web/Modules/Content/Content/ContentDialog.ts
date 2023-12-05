import { ContentForm, ContentRow, ContentService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentDialog')
export class ContentDialog extends EntityDialog<ContentRow, any> {
    protected getFormKey() { return ContentForm.formKey; }
    protected getRowDefinition() { return ContentRow; }
    protected getService() { return ContentService.baseUrl; }

    protected form = new ContentForm(this.idPrefix);
}