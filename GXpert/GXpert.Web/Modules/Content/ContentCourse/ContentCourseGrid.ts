import { ContentCourseColumns, ContentCourseRow, ContentCourseService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentCourseDialog } from './ContentCourseDialog';

@Decorators.registerClass('GXpert.Content.ContentCourseGrid')
export class ContentCourseGrid extends EntityGrid<ContentCourseRow, any> {
    protected getColumnsKey() { return ContentCourseColumns.columnsKey; }
    protected getDialogType() { return ContentCourseDialog; }
    protected getRowDefinition() { return ContentCourseRow; }
    protected getService() { return ContentCourseService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}