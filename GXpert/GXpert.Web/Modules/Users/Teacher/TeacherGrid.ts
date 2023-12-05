import { TeacherColumns, TeacherRow, TeacherService } from '@/ServerTypes/Users';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TeacherDialog } from './TeacherDialog';

@Decorators.registerClass('GXpert.Users.TeacherGrid')
export class TeacherGrid extends EntityGrid<TeacherRow, any> {
    protected getColumnsKey() { return TeacherColumns.columnsKey; }
    protected getDialogType() { return TeacherDialog; }
    protected getRowDefinition() { return TeacherRow; }
    protected getService() { return TeacherService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}