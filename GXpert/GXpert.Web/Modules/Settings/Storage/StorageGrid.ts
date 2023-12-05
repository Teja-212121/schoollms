import { StorageColumns, StorageRow, StorageService } from '@/ServerTypes/Settings';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StorageDialog } from './StorageDialog';

@Decorators.registerClass('GXpert.Settings.StorageGrid')
export class StorageGrid extends EntityGrid<StorageRow, any> {
    protected getColumnsKey() { return StorageColumns.columnsKey; }
    protected getDialogType() { return StorageDialog; }
    protected getRowDefinition() { return StorageRow; }
    protected getService() { return StorageService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}