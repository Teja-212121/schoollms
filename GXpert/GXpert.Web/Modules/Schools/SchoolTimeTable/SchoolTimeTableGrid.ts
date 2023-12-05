import { SchoolTimeTableColumns, SchoolTimeTableRow, SchoolTimeTableService } from '@/ServerTypes/Schools';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SchoolTimeTableDialog } from './SchoolTimeTableDialog';

@Decorators.registerClass('GXpert.Schools.SchoolTimeTableGrid')
export class SchoolTimeTableGrid extends EntityGrid<SchoolTimeTableRow, any> {
    protected getColumnsKey() { return SchoolTimeTableColumns.columnsKey; }
    protected getDialogType() { return SchoolTimeTableDialog; }
    protected getRowDefinition() { return SchoolTimeTableRow; }
    protected getService() { return SchoolTimeTableService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}