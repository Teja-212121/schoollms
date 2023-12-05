import { AssignmentEvaluationColumns, AssignmentEvaluationRow, AssignmentEvaluationService } from '@/ServerTypes/Exams';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AssignmentEvaluationDialog } from './AssignmentEvaluationDialog';

@Decorators.registerClass('GXpert.Exams.AssignmentEvaluationGrid')
export class AssignmentEvaluationGrid extends EntityGrid<AssignmentEvaluationRow, any> {
    protected getColumnsKey() { return AssignmentEvaluationColumns.columnsKey; }
    protected getDialogType() { return AssignmentEvaluationDialog; }
    protected getRowDefinition() { return AssignmentEvaluationRow; }
    protected getService() { return AssignmentEvaluationService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}