import { PollColumns, PollRow, PollService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PollDialog } from './PollDialog';

@Decorators.registerClass('GXpert.LiveSessions.PollGrid')
export class PollGrid extends EntityGrid<PollRow, any> {
    protected getColumnsKey() { return PollColumns.columnsKey; }
    protected getDialogType() { return PollDialog; }
    protected getRowDefinition() { return PollRow; }
    protected getService() { return PollService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}