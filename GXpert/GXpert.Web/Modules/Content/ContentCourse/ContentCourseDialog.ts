import { ContentCourseForm, ContentCourseRow, ContentCourseService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentCourseDialog')
export class ContentCourseDialog extends EntityDialog<ContentCourseRow, any> {
    protected getFormKey() { return ContentCourseForm.formKey; }
    protected getRowDefinition() { return ContentCourseRow; }
    protected getService() { return ContentCourseService.baseUrl; }

    protected form = new ContentCourseForm(this.idPrefix);
}