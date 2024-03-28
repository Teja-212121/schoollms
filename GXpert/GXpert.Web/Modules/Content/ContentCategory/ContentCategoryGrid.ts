import { ContentCategoryColumns, ContentCategoryRow, ContentCategoryService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentCategoryDialog } from './ContentCategoryDialog';

@Decorators.registerClass('GXpert.Content.ContentCategoryGrid')
export class ContentCategoryGrid extends EntityGrid<ContentCategoryRow, any> {
    protected getColumnsKey() { return ContentCategoryColumns.columnsKey; }
    protected getDialogType() { return ContentCategoryDialog; }
    protected getRowDefinition() { return ContentCategoryRow; }
    protected getService() { return ContentCategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}