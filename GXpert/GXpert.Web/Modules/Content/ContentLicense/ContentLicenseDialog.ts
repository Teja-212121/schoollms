import { ContentLicenseForm, ContentLicenseRow, ContentLicenseService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Content.ContentLicenseDialog')
export class ContentLicenseDialog extends EntityDialog<ContentLicenseRow, any> {
    protected getFormKey() { return ContentLicenseForm.formKey; }
    protected getRowDefinition() { return ContentLicenseRow; }
    protected getService() { return ContentLicenseService.baseUrl; }

    protected form = new ContentLicenseForm(this.idPrefix);
}