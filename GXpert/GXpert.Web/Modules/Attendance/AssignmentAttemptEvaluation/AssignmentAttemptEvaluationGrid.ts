import { AssignmentAttemptEvaluationColumns, AssignmentAttemptEvaluationRow, AssignmentAttemptEvaluationService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AssignmentAttemptEvaluationDialog } from './AssignmentAttemptEvaluationDialog';

@Decorators.registerClass('GXpert.Attendance.AssignmentAttemptEvaluationGrid')
export class AssignmentAttemptEvaluationGrid extends EntityGrid<AssignmentAttemptEvaluationRow, any> {
    protected getColumnsKey() { return AssignmentAttemptEvaluationColumns.columnsKey; }
    protected getDialogType() { return AssignmentAttemptEvaluationDialog; }
    protected getRowDefinition() { return AssignmentAttemptEvaluationRow; }
    protected getService() { return AssignmentAttemptEvaluationService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}