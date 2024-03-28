import { ContentAudioForm, ContentAudioRow, ContentAudioService } from '@/ServerTypes/Content';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentAudioDialog')
export class ContentAudioDialog extends EntityDialog<ContentAudioRow, any> {
    protected getFormKey() { return ContentAudioForm.formKey; }
    protected getRowDefinition() { return ContentAudioRow; }
    protected getService() { return ContentAudioService.baseUrl; }

    protected form = new ContentAudioForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.ContentId, true);
    }
}