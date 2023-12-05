import { SchoolTeacherColumns, SchoolTeacherRow, SchoolTeacherService } from '@/ServerTypes/Schools';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SchoolTeacherDialog } from './SchoolTeacherDialog';

@Decorators.registerClass('GXpert.Schools.SchoolTeacherGrid')
export class SchoolTeacherGrid extends EntityGrid<SchoolTeacherRow, any> {
    protected getColumnsKey() { return SchoolTeacherColumns.columnsKey; }
    protected getDialogType() { return SchoolTeacherDialog; }
    protected getRowDefinition() { return SchoolTeacherRow; }
    protected getService() { return SchoolTeacherService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}