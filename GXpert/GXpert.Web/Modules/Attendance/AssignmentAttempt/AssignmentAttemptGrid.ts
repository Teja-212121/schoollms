import { AssignmentAttemptColumns, AssignmentAttemptRow, AssignmentAttemptService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AssignmentAttemptDialog } from './AssignmentAttemptDialog';

@Decorators.registerClass('GXpert.Attendance.AssignmentAttemptGrid')
export class AssignmentAttemptGrid extends EntityGrid<AssignmentAttemptRow, any> {
    protected getColumnsKey() { return AssignmentAttemptColumns.columnsKey; }
    protected getDialogType() { return AssignmentAttemptDialog; }
    protected getRowDefinition() { return AssignmentAttemptRow; }
    protected getService() { return AssignmentAttemptService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}