import { ContentBloomsIndexColumns, ContentBloomsIndexRow, ContentBloomsIndexService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentBloomsIndexDialog } from './ContentBloomsIndexDialog';

@Decorators.registerClass('GXpert.Content.ContentBloomsIndexGrid')
export class ContentBloomsIndexGrid extends EntityGrid<ContentBloomsIndexRow, any> {
    protected getColumnsKey() { return ContentBloomsIndexColumns.columnsKey; }
    protected getDialogType() { return ContentBloomsIndexDialog; }
    protected getRowDefinition() { return ContentBloomsIndexRow; }
    protected getService() { return ContentBloomsIndexService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}