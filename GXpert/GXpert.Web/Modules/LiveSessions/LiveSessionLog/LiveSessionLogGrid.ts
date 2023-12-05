import { LiveSessionLogColumns, LiveSessionLogRow, LiveSessionLogService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LiveSessionLogDialog } from './LiveSessionLogDialog';

@Decorators.registerClass('GXpert.LiveSessions.LiveSessionLogGrid')
export class LiveSessionLogGrid extends EntityGrid<LiveSessionLogRow, any> {
    protected getColumnsKey() { return LiveSessionLogColumns.columnsKey; }
    protected getDialogType() { return LiveSessionLogDialog; }
    protected getRowDefinition() { return LiveSessionLogRow; }
    protected getService() { return LiveSessionLogService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}