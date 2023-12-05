import { TopicColumns, TopicRow, TopicService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TopicDialog } from './TopicDialog';

@Decorators.registerClass('GXpert.Syllabus.TopicGrid')
export class TopicGrid extends EntityGrid<TopicRow, any> {
    protected getColumnsKey() { return TopicColumns.columnsKey; }
    protected getDialogType() { return TopicDialog; }
    protected getRowDefinition() { return TopicRow; }
    protected getService() { return TopicService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}