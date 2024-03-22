import { InstituteColumns, InstituteRow, InstituteService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteDialog } from './InstituteDialog';

@Decorators.registerClass('GXpert.Institute.InstituteGrid')
export class InstituteGrid extends EntityGrid<InstituteRow, any> {
    protected getColumnsKey() { return InstituteColumns.columnsKey; }
    protected getDialogType() { return InstituteDialog; }
    protected getRowDefinition() { return InstituteRow; }
    protected getService() { return InstituteService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}