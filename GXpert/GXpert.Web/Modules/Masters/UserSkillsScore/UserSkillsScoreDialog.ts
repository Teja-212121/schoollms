import { UserSkillsScoreForm, UserSkillsScoreRow, UserSkillsScoreService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.UserSkillsScoreDialog')
export class UserSkillsScoreDialog extends EntityDialog<UserSkillsScoreRow, any> {
    protected getFormKey() { return UserSkillsScoreForm.formKey; }
    protected getRowDefinition() { return UserSkillsScoreRow; }
    protected getService() { return UserSkillsScoreService.baseUrl; }

    protected form = new UserSkillsScoreForm(this.idPrefix);
}