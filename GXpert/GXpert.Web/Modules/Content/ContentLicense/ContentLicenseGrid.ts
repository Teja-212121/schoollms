import { ContentLicenseColumns, ContentLicenseRow, ContentLicenseService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentLicenseDialog } from './ContentLicenseDialog';

@Decorators.registerClass('GXpert.Content.ContentLicenseGrid')
export class ContentLicenseGrid extends EntityGrid<ContentLicenseRow, any> {
    protected getColumnsKey() { return ContentLicenseColumns.columnsKey; }
    protected getDialogType() { return ContentLicenseDialog; }
    protected getRowDefinition() { return ContentLicenseRow; }
    protected getService() { return ContentLicenseService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}