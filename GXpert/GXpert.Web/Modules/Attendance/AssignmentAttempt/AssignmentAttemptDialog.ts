import { AssignmentAttemptForm, AssignmentAttemptRow, AssignmentAttemptService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.AssignmentAttemptDialog')
export class AssignmentAttemptDialog extends EntityDialog<AssignmentAttemptRow, any> {
    protected getFormKey() { return AssignmentAttemptForm.formKey; }
    protected getRowDefinition() { return AssignmentAttemptRow; }
    protected getService() { return AssignmentAttemptService.baseUrl; }

    protected form = new AssignmentAttemptForm(this.idPrefix);
}