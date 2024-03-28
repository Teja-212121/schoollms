import { ContentCategoryForm, ContentCategoryRow, ContentCategoryService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentCategoryDialog')
export class ContentCategoryDialog extends EntityDialog<ContentCategoryRow, any> {
    protected getFormKey() { return ContentCategoryForm.formKey; }
    protected getRowDefinition() { return ContentCategoryRow; }
    protected getService() { return ContentCategoryService.baseUrl; }

    protected form = new ContentCategoryForm(this.idPrefix);
}