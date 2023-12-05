import { LiveSessionColumns, LiveSessionRow, LiveSessionService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LiveSessionDialog } from './LiveSessionDialog';

@Decorators.registerClass('GXpert.LiveSessions.LiveSessionGrid')
export class LiveSessionGrid extends EntityGrid<LiveSessionRow, any> {
    protected getColumnsKey() { return LiveSessionColumns.columnsKey; }
    protected getDialogType() { return LiveSessionDialog; }
    protected getRowDefinition() { return LiveSessionRow; }
    protected getService() { return LiveSessionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}