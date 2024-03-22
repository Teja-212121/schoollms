import { HodColumns, HodRow, HodService } from '@/ServerTypes/Users';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { HodDialog } from './HodDialog';

@Decorators.registerClass('GXpert.Users.HodGrid')
export class HodGrid extends EntityGrid<HodRow, any> {
    protected getColumnsKey() { return HodColumns.columnsKey; }
    protected getDialogType() { return HodDialog; }
    protected getRowDefinition() { return HodRow; }
    protected getService() { return HodService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}