import { ModuleColumns, ModuleRow, ModuleService } from '@/ServerTypes/Playlist';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ModuleDialog } from './ModuleDialog';

@Decorators.registerClass('GXpert.Playlist.ModuleGrid')
export class ModuleGrid extends EntityGrid<ModuleRow, any> {
    protected getColumnsKey() { return ModuleColumns.columnsKey; }
    protected getDialogType() { return ModuleDialog; }
    protected getRowDefinition() { return ModuleRow; }
    protected getService() { return ModuleService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}