import { PreAcademicColumns, PreAcademicRow, PreAcademicService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PreAcademicDialog } from './PreAcademicDialog';

@Decorators.registerClass('GXpert.Masters.PreAcademicGrid')
export class PreAcademicGrid extends EntityGrid<PreAcademicRow, any> {
    protected getColumnsKey() { return PreAcademicColumns.columnsKey; }
    protected getDialogType() { return PreAcademicDialog; }
    protected getRowDefinition() { return PreAcademicRow; }
    protected getService() { return PreAcademicService.baseUrl; }

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

    set ContentId(value: string) {
        if (this._StudentId !== value) {
            this._StudentId = value;
            this.setEquality('StudentId', value);
            this.refresh();
        }
    }
}