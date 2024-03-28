import { ContentMediaRatingForm, ContentMediaRatingRow, ContentMediaRatingService } from '@/ServerTypes/Content';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentMediaRatingDialog')
export class ContentMediaRatingDialog extends EntityDialog<ContentMediaRatingRow, any> {
    protected getFormKey() { return ContentMediaRatingForm.formKey; }
    protected getRowDefinition() { return ContentMediaRatingRow; }
    protected getService() { return ContentMediaRatingService.baseUrl; }

    protected form = new ContentMediaRatingForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.ContentId, true);
    }
}