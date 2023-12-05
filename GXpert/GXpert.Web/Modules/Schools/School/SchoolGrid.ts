import { SchoolColumns, SchoolRow, SchoolService } from '@/ServerTypes/Schools';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SchoolDialog } from './SchoolDialog';

@Decorators.registerClass('GXpert.Schools.SchoolGrid')
export class SchoolGrid extends EntityGrid<SchoolRow, any> {
    protected getColumnsKey() { return SchoolColumns.columnsKey; }
    protected getDialogType() { return SchoolDialog; }
    protected getRowDefinition() { return SchoolRow; }
    protected getService() { return SchoolService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}