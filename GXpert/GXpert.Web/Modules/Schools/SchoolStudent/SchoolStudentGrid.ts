import { SchoolStudentColumns, SchoolStudentRow, SchoolStudentService } from '@/ServerTypes/Schools';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SchoolStudentDialog } from './SchoolStudentDialog';

@Decorators.registerClass('GXpert.Schools.SchoolStudentGrid')
export class SchoolStudentGrid extends EntityGrid<SchoolStudentRow, any> {
    protected getColumnsKey() { return SchoolStudentColumns.columnsKey; }
    protected getDialogType() { return SchoolStudentDialog; }
    protected getRowDefinition() { return SchoolStudentRow; }
    protected getService() { return SchoolStudentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}