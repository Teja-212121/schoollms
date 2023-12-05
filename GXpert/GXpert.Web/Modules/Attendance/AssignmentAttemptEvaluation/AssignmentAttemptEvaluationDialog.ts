import { AssignmentAttemptEvaluationForm, AssignmentAttemptEvaluationRow, AssignmentAttemptEvaluationService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.AssignmentAttemptEvaluationDialog')
export class AssignmentAttemptEvaluationDialog extends EntityDialog<AssignmentAttemptEvaluationRow, any> {
    protected getFormKey() { return AssignmentAttemptEvaluationForm.formKey; }
    protected getRowDefinition() { return AssignmentAttemptEvaluationRow; }
    protected getService() { return AssignmentAttemptEvaluationService.baseUrl; }

    protected form = new AssignmentAttemptEvaluationForm(this.idPrefix);
}