import { AcademicPerformanceColumns, AcademicPerformanceRow, AcademicPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicPerformanceDialog } from './AcademicPerformanceDialog';

@Decorators.registerClass('GXpert.Masters.AcademicPerformanceGrid')
export class AcademicPerformanceGrid extends EntityGrid<AcademicPerformanceRow, any> {
    protected getColumnsKey() { return AcademicPerformanceColumns.columnsKey; }
    protected getDialogType() { return AcademicPerformanceDialog; }
    protected getRowDefinition() { return AcademicPerformanceRow; }
    protected getService() { return AcademicPerformanceService.baseUrl; }

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