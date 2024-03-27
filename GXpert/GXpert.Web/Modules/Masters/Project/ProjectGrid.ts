import { ProjectColumns, ProjectRow, ProjectService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProjectDialog } from './ProjectDialog';

@Decorators.registerClass('GXpert.Masters.ProjectGrid')
export class ProjectGrid extends EntityGrid<ProjectRow, any> {
    protected getColumnsKey() { return ProjectColumns.columnsKey; }
    protected getDialogType() { return ProjectDialog; }
    protected getRowDefinition() { return ProjectRow; }
    protected getService() { return ProjectService.baseUrl; }

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