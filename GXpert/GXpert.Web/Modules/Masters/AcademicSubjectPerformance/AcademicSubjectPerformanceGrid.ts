import { AcademicSubjectPerformanceColumns, AcademicSubjectPerformanceRow, AcademicSubjectPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicSubjectPerformanceDialog } from './AcademicSubjectPerformanceDialog';

@Decorators.registerClass('GXpert.Masters.AcademicSubjectPerformanceGrid')
export class AcademicSubjectPerformanceGrid extends EntityGrid<AcademicSubjectPerformanceRow, any> {
    protected getColumnsKey() { return AcademicSubjectPerformanceColumns.columnsKey; }
    protected getDialogType() { return AcademicSubjectPerformanceDialog; }
    protected getRowDefinition() { return AcademicSubjectPerformanceRow; }
    protected getService() { return AcademicSubjectPerformanceService.baseUrl; }

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