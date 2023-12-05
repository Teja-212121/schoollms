import { ContentTopicColumns, ContentTopicRow, ContentTopicService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentTopicDialog } from './ContentTopicDialog';

@Decorators.registerClass('GXpert.Content.ContentTopicGrid')
export class ContentTopicGrid extends EntityGrid<ContentTopicRow, any> {
    protected getColumnsKey() { return ContentTopicColumns.columnsKey; }
    protected getDialogType() { return ContentTopicDialog; }
    protected getRowDefinition() { return ContentTopicRow; }
    protected getService() { return ContentTopicService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}