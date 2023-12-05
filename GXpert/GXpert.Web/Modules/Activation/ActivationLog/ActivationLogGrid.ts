import { ActivationLogColumns, ActivationLogRow, ActivationLogService } from '@/ServerTypes/Activation';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ActivationLogDialog } from './ActivationLogDialog';

@Decorators.registerClass('GXpert.Activation.ActivationLogGrid')
export class ActivationLogGrid extends EntityGrid<ActivationLogRow, any> {
    protected getColumnsKey() { return ActivationLogColumns.columnsKey; }
    protected getDialogType() { return ActivationLogDialog; }
    protected getRowDefinition() { return ActivationLogRow; }
    protected getService() { return ActivationLogService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}