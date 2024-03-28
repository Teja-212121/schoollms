import { ContentLanguageForm, ContentLanguageRow, ContentLanguageService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentLanguageDialog')
export class ContentLanguageDialog extends EntityDialog<ContentLanguageRow, any> {
    protected getFormKey() { return ContentLanguageForm.formKey; }
    protected getRowDefinition() { return ContentLanguageRow; }
    protected getService() { return ContentLanguageService.baseUrl; }

    protected form = new ContentLanguageForm(this.idPrefix);
}