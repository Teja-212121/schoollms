import { ProjectForm, ProjectRow, ProjectService } from '@/ServerTypes/Masters';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.ProjectDialog')
export class ProjectDialog extends EntityDialog<ProjectRow, any> {
    protected getFormKey() { return ProjectForm.formKey; }
    protected getRowDefinition() { return ProjectRow; }
    protected getService() { return ProjectService.baseUrl; }

    protected form = new ProjectForm(this.idPrefix);
    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.StudentId, true);
    }
}