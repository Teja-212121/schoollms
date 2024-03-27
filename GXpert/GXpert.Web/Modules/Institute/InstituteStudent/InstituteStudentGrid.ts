import { InstituteStudentColumns, InstituteStudentRow, InstituteStudentService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteStudentDialog } from './InstituteStudentDialog';

@Decorators.registerClass('GXpert.Institute.InstituteStudentGrid')
export class InstituteStudentGrid extends EntityGrid<InstituteStudentRow, any> {
    protected getColumnsKey() { return InstituteStudentColumns.columnsKey; }
    protected getDialogType() { return InstituteStudentDialog; }
    protected getRowDefinition() { return InstituteStudentRow; }
    protected getService() { return InstituteStudentService.baseUrl; }

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