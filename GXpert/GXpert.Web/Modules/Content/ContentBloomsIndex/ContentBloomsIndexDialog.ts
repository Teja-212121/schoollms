import { ContentBloomsIndexForm, ContentBloomsIndexRow, ContentBloomsIndexService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentBloomsIndexDialog')
export class ContentBloomsIndexDialog extends EntityDialog<ContentBloomsIndexRow, any> {
    protected getFormKey() { return ContentBloomsIndexForm.formKey; }
    protected getRowDefinition() { return ContentBloomsIndexRow; }
    protected getService() { return ContentBloomsIndexService.baseUrl; }

    protected form = new ContentBloomsIndexForm(this.idPrefix);
}