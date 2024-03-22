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
}