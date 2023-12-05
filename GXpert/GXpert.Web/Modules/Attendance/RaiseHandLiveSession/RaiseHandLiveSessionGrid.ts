import { RaiseHandLiveSessionColumns, RaiseHandLiveSessionRow, RaiseHandLiveSessionService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { RaiseHandLiveSessionDialog } from './RaiseHandLiveSessionDialog';

@Decorators.registerClass('GXpert.Attendance.RaiseHandLiveSessionGrid')
export class RaiseHandLiveSessionGrid extends EntityGrid<RaiseHandLiveSessionRow, any> {
    protected getColumnsKey() { return RaiseHandLiveSessionColumns.columnsKey; }
    protected getDialogType() { return RaiseHandLiveSessionDialog; }
    protected getRowDefinition() { return RaiseHandLiveSessionRow; }
    protected getService() { return RaiseHandLiveSessionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}