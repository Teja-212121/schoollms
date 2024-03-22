import { InstituteTimeTableColumns, InstituteTimeTableRow, InstituteTimeTableService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteTimeTableDialog } from './InstituteTimeTableDialog';

@Decorators.registerClass('GXpert.Institute.InstituteTimeTableGrid')
export class InstituteTimeTableGrid extends EntityGrid<InstituteTimeTableRow, any> {
    protected getColumnsKey() { return InstituteTimeTableColumns.columnsKey; }
    protected getDialogType() { return InstituteTimeTableDialog; }
    protected getRowDefinition() { return InstituteTimeTableRow; }
    protected getService() { return InstituteTimeTableService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}