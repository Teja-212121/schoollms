import { ActivationColumns, ActivationRow, ActivationService } from '@/ServerTypes/Activation';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ActivationDialog } from './ActivationDialog';

@Decorators.registerClass('GXpert.Activation.ActivationGrid')
export class ActivationGrid extends EntityGrid<ActivationRow, any> {
    protected getColumnsKey() { return ActivationColumns.columnsKey; }
    protected getDialogType() { return ActivationDialog; }
    protected getRowDefinition() { return ActivationRow; }
    protected getService() { return ActivationService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}