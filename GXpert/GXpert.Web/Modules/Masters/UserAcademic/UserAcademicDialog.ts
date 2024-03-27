import { UserAcademicForm, UserAcademicRow, UserAcademicService } from '@/ServerTypes/Masters';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.UserAcademicDialog')
export class UserAcademicDialog extends EntityDialog<UserAcademicRow, any> {
    protected getFormKey() { return UserAcademicForm.formKey; }
    protected getRowDefinition() { return UserAcademicRow; }
    protected getService() { return UserAcademicService.baseUrl; }

    protected form = new UserAcademicForm(this.idPrefix);
    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.StudentId, true);
    }
}