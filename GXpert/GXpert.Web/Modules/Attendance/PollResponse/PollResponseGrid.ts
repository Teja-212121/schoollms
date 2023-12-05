import { PollResponseColumns, PollResponseRow, PollResponseService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PollResponseDialog } from './PollResponseDialog';

@Decorators.registerClass('GXpert.Attendance.PollResponseGrid')
export class PollResponseGrid extends EntityGrid<PollResponseRow, any> {
    protected getColumnsKey() { return PollResponseColumns.columnsKey; }
    protected getDialogType() { return PollResponseDialog; }
    protected getRowDefinition() { return PollResponseRow; }
    protected getService() { return PollResponseService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}