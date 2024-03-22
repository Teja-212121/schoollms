import { InstituteTeacherColumns, InstituteTeacherRow, InstituteTeacherService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteTeacherDialog } from './InstituteTeacherDialog';

@Decorators.registerClass('GXpert.Institute.InstituteTeacherGrid')
export class InstituteTeacherGrid extends EntityGrid<InstituteTeacherRow, any> {
    protected getColumnsKey() { return InstituteTeacherColumns.columnsKey; }
    protected getDialogType() { return InstituteTeacherDialog; }
    protected getRowDefinition() { return InstituteTeacherRow; }
    protected getService() { return InstituteTeacherService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}