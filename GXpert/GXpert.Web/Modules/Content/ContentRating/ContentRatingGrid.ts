import { ContentRatingColumns, ContentRatingRow, ContentRatingService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentRatingDialog } from './ContentRatingDialog';

@Decorators.registerClass('GXpert.Content.ContentRatingGrid')
export class ContentRatingGrid extends EntityGrid<ContentRatingRow, any> {
    protected getColumnsKey() { return ContentRatingColumns.columnsKey; }
    protected getDialogType() { return ContentRatingDialog; }
    protected getRowDefinition() { return ContentRatingRow; }
    protected getService() { return ContentRatingService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}