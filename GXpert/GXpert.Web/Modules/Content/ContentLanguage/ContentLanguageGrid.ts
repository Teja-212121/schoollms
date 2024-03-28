import { ContentLanguageColumns, ContentLanguageRow, ContentLanguageService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentLanguageDialog } from './ContentLanguageDialog';

@Decorators.registerClass('GXpert.Content.ContentLanguageGrid')
export class ContentLanguageGrid extends EntityGrid<ContentLanguageRow, any> {
    protected getColumnsKey() { return ContentLanguageColumns.columnsKey; }
    protected getDialogType() { return ContentLanguageDialog; }
    protected getRowDefinition() { return ContentLanguageRow; }
    protected getService() { return ContentLanguageService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}