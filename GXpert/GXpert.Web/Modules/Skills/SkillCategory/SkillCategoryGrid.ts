import { SkillCategoryColumns, SkillCategoryRow, SkillCategoryService } from '@/ServerTypes/Skills';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SkillCategoryDialog } from './SkillCategoryDialog';

@Decorators.registerClass('GXpert.Skills.SkillCategoryGrid')
export class SkillCategoryGrid extends EntityGrid<SkillCategoryRow, any> {
    protected getColumnsKey() { return SkillCategoryColumns.columnsKey; }
    protected getDialogType() { return SkillCategoryDialog; }
    protected getRowDefinition() { return SkillCategoryRow; }
    protected getService() { return SkillCategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}