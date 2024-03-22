import { DepartmentColumns, DepartmentRow, DepartmentService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DepartmentDialog } from './DepartmentDialog';

@Decorators.registerClass('GXpert.Institute.DepartmentGrid')
export class DepartmentGrid extends EntityGrid<DepartmentRow, any> {
    protected getColumnsKey() { return DepartmentColumns.columnsKey; }
    protected getDialogType() { return DepartmentDialog; }
    protected getRowDefinition() { return DepartmentRow; }
    protected getService() { return DepartmentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}