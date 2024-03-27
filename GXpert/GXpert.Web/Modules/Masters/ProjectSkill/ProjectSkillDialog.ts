import { ProjectSkillForm, ProjectSkillRow, ProjectSkillService } from '@/ServerTypes/Masters';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.ProjectSkillDialog')
export class ProjectSkillDialog extends EntityDialog<ProjectSkillRow, any> {
    protected getFormKey() { return ProjectSkillForm.formKey; }
    protected getRowDefinition() { return ProjectSkillRow; }
    protected getService() { return ProjectSkillService.baseUrl; }

    protected form = new ProjectSkillForm(this.idPrefix);
    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.StudentId, true);
    }
}