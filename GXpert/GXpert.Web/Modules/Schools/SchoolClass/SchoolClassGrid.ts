import { SchoolClassColumns, SchoolClassRow, SchoolClassService } from '@/ServerTypes/Schools';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SchoolClassDialog } from './SchoolClassDialog';

@Decorators.registerClass('GXpert.Schools.SchoolClassGrid')
export class SchoolClassGrid extends EntityGrid<SchoolClassRow, any> {
    protected getColumnsKey() { return SchoolClassColumns.columnsKey; }
    protected getDialogType() { return SchoolClassDialog; }
    protected getRowDefinition() { return SchoolClassRow; }
    protected getService() { return SchoolClassService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}