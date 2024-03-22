import { SkillColumns, SkillRow, SkillService } from '@/ServerTypes/Skills';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SkillDialog } from './SkillDialog';

@Decorators.registerClass('GXpert.Skills.SkillGrid')
export class SkillGrid extends EntityGrid<SkillRow, any> {
    protected getColumnsKey() { return SkillColumns.columnsKey; }
    protected getDialogType() { return SkillDialog; }
    protected getRowDefinition() { return SkillRow; }
    protected getService() { return SkillService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}