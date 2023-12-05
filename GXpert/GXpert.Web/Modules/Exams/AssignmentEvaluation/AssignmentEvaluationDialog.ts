import { AssignmentEvaluationForm, AssignmentEvaluationRow, AssignmentEvaluationService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.AssignmentEvaluationDialog')
export class AssignmentEvaluationDialog extends EntityDialog<AssignmentEvaluationRow, any> {
    protected getFormKey() { return AssignmentEvaluationForm.formKey; }
    protected getRowDefinition() { return AssignmentEvaluationRow; }
    protected getService() { return AssignmentEvaluationService.baseUrl; }

    protected form = new AssignmentEvaluationForm(this.idPrefix);
}