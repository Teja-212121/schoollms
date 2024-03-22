import { SkillCategoryForm, SkillCategoryRow, SkillCategoryService } from '@/ServerTypes/Skills';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Skills.SkillCategoryDialog')
export class SkillCategoryDialog extends EntityDialog<SkillCategoryRow, any> {
    protected getFormKey() { return SkillCategoryForm.formKey; }
    protected getRowDefinition() { return SkillCategoryRow; }
    protected getService() { return SkillCategoryService.baseUrl; }

    protected form = new SkillCategoryForm(this.idPrefix);
}