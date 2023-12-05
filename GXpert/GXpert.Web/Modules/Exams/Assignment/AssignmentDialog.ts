import { AssignmentForm, AssignmentRow, AssignmentService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.AssignmentDialog')
export class AssignmentDialog extends EntityDialog<AssignmentRow, any> {
    protected getFormKey() { return AssignmentForm.formKey; }
    protected getRowDefinition() { return AssignmentRow; }
    protected getService() { return AssignmentService.baseUrl; }

    protected form = new AssignmentForm(this.idPrefix);
}