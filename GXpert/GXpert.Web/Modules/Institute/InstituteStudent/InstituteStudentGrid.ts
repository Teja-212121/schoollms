import { InstituteStudentColumns, InstituteStudentRow, InstituteStudentService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteStudentDialog } from './InstituteStudentDialog';

@Decorators.registerClass('GXpert.Institute.InstituteStudentGrid')
export class InstituteStudentGrid extends EntityGrid<InstituteStudentRow, any> {
    protected getColumnsKey() { return InstituteStudentColumns.columnsKey; }
    protected getDialogType() { return InstituteStudentDialog; }
    protected getRowDefinition() { return InstituteStudentRow; }
    protected getService() { return InstituteStudentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}