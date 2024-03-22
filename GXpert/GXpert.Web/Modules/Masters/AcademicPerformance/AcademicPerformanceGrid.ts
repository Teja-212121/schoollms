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
}