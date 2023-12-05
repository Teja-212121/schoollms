import { AssignedExamTeachersForm, AssignedExamTeachersRow, AssignedExamTeachersService } from '@/ServerTypes/Analytics';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Analytics.AssignedExamTeachersDialog')
export class AssignedExamTeachersDialog extends EntityDialog<AssignedExamTeachersRow, any> {
    protected getFormKey() { return AssignedExamTeachersForm.formKey; }
    protected getRowDefinition() { return AssignedExamTeachersRow; }
    protected getService() { return AssignedExamTeachersService.baseUrl; }

    protected form = new AssignedExamTeachersForm(this.idPrefix);
}