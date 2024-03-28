import { ContentCommentForm, ContentCommentRow, ContentCommentService } from '@/ServerTypes/Content';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentCommentDialog')
export class ContentCommentDialog extends EntityDialog<ContentCommentRow, any> {
    protected getFormKey() { return ContentCommentForm.formKey; }
    protected getRowDefinition() { return ContentCommentRow; }
    protected getService() { return ContentCommentService.baseUrl; }

    protected form = new ContentCommentForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.ContentId, true);
    }
}