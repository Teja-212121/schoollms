import { PreDefinedKeyColumns, PreDefinedKeyRow, PreDefinedKeyService } from '@/ServerTypes/Activation';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PreDefinedKeyDialog } from './PreDefinedKeyDialog';

@Decorators.registerClass('GXpert.Activation.PreDefinedKeyGrid')
export class PreDefinedKeyGrid extends EntityGrid<PreDefinedKeyRow, any> {
    protected getColumnsKey() { return PreDefinedKeyColumns.columnsKey; }
    protected getDialogType() { return PreDefinedKeyDialog; }
    protected getRowDefinition() { return PreDefinedKeyRow; }
    protected getService() { return PreDefinedKeyService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}