import { ContentRatingForm, ContentRatingRow, ContentRatingService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentRatingDialog')
export class ContentRatingDialog extends EntityDialog<ContentRatingRow, any> {
    protected getFormKey() { return ContentRatingForm.formKey; }
    protected getRowDefinition() { return ContentRatingRow; }
    protected getService() { return ContentRatingService.baseUrl; }

    protected form = new ContentRatingForm(this.idPrefix);
}