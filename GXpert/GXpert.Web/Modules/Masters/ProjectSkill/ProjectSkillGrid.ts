import { ProjectSkillColumns, ProjectSkillRow, ProjectSkillService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProjectSkillDialog } from './ProjectSkillDialog';

@Decorators.registerClass('GXpert.Masters.ProjectSkillGrid')
export class ProjectSkillGrid extends EntityGrid<ProjectSkillRow, any> {
    protected getColumnsKey() { return ProjectSkillColumns.columnsKey; }
    protected getDialogType() { return ProjectSkillDialog; }
    protected getRowDefinition() { return ProjectSkillRow; }
    protected getService() { return ProjectSkillService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected addButtonClick() {
        this.editItem({ StudentId: this.StudentId });
    }

    protected getInitialTitle() {
        return null;
    }

    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.StudentId;
    }

    private _StudentId: string;

    get StudentId() {
        return this._StudentId;
    }

    set StudentId(value: string) {
        if (this._StudentId !== value) {
            this._StudentId = value;
            this.setEquality('StudentId', value);
            this.refresh();
        }
    }
}