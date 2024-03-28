import { ContentSubtitleForm, ContentSubtitleRow, ContentSubtitleService } from '@/ServerTypes/Content';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentSubtitleDialog')
export class ContentSubtitleDialog extends EntityDialog<ContentSubtitleRow, any> {
    protected getFormKey() { return ContentSubtitleForm.formKey; }
    protected getRowDefinition() { return ContentSubtitleRow; }
    protected getService() { return ContentSubtitleService.baseUrl; }

    protected form = new ContentSubtitleForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.ContentId, true);
    }
}