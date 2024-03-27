import { PreAcademicScoreColumns, PreAcademicScoreRow, PreAcademicScoreService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PreAcademicScoreDialog } from './PreAcademicScoreDialog';

@Decorators.registerClass('GXpert.Masters.PreAcademicScoreGrid')
export class PreAcademicScoreGrid extends EntityGrid<PreAcademicScoreRow, any> {
    protected getColumnsKey() { return PreAcademicScoreColumns.columnsKey; }
    protected getDialogType() { return PreAcademicScoreDialog; }
    protected getRowDefinition() { return PreAcademicScoreRow; }
    protected getService() { return PreAcademicScoreService.baseUrl; }

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