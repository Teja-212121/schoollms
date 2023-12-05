import { SerialKeyColumns, SerialKeyRow, SerialKeyService } from '@/ServerTypes/Activation';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SerialKeyDialog } from './SerialKeyDialog';

@Decorators.registerClass('GXpert.Activation.SerialKeyGrid')
export class SerialKeyGrid extends EntityGrid<SerialKeyRow, any> {
    protected getColumnsKey() { return SerialKeyColumns.columnsKey; }
    protected getDialogType() { return SerialKeyDialog; }
    protected getRowDefinition() { return SerialKeyRow; }
    protected getService() { return SerialKeyService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}