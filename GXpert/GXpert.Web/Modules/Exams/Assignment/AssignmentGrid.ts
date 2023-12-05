import { AssignmentColumns, AssignmentRow, AssignmentService } from '@/ServerTypes/Exams';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AssignmentDialog } from './AssignmentDialog';

@Decorators.registerClass('GXpert.Exams.AssignmentGrid')
export class AssignmentGrid extends EntityGrid<AssignmentRow, any> {
    protected getColumnsKey() { return AssignmentColumns.columnsKey; }
    protected getDialogType() { return AssignmentDialog; }
    protected getRowDefinition() { return AssignmentRow; }
    protected getService() { return AssignmentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}