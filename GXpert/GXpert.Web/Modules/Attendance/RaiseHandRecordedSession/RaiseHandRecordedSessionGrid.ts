import { RaiseHandRecordedSessionColumns, RaiseHandRecordedSessionRow, RaiseHandRecordedSessionService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { RaiseHandRecordedSessionDialog } from './RaiseHandRecordedSessionDialog';

@Decorators.registerClass('GXpert.Attendance.RaiseHandRecordedSessionGrid')
export class RaiseHandRecordedSessionGrid extends EntityGrid<RaiseHandRecordedSessionRow, any> {
    protected getColumnsKey() { return RaiseHandRecordedSessionColumns.columnsKey; }
    protected getDialogType() { return RaiseHandRecordedSessionDialog; }
    protected getRowDefinition() { return RaiseHandRecordedSessionRow; }
    protected getService() { return RaiseHandRecordedSessionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}