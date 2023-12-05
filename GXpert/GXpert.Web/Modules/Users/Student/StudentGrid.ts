import { StudentColumns, StudentRow, StudentService } from '@/ServerTypes/Users';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StudentDialog } from './StudentDialog';

@Decorators.registerClass('GXpert.Users.StudentGrid')
export class StudentGrid extends EntityGrid<StudentRow, any> {
    protected getColumnsKey() { return StudentColumns.columnsKey; }
    protected getDialogType() { return StudentDialog; }
    protected getRowDefinition() { return StudentRow; }
    protected getService() { return StudentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}