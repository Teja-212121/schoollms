import { SkillForm, SkillRow, SkillService } from '@/ServerTypes/Skills';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Skills.SkillDialog')
export class SkillDialog extends EntityDialog<SkillRow, any> {
    protected getFormKey() { return SkillForm.formKey; }
    protected getRowDefinition() { return SkillRow; }
    protected getService() { return SkillService.baseUrl; }

    protected form = new SkillForm(this.idPrefix);
}