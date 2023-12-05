import { ContentColumns, ContentRow, ContentService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentDialog } from './ContentDialog';

@Decorators.registerClass('GXpert.Content.ContentGrid')
export class ContentGrid extends EntityGrid<ContentRow, any> {
    protected getColumnsKey() { return ContentColumns.columnsKey; }
    protected getDialogType() { return ContentDialog; }
    protected getRowDefinition() { return ContentRow; }
    protected getService() { return ContentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}