import { AcademicYearColumns, AcademicYearRow, AcademicYearService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicYearDialog } from './AcademicYearDialog';

@Decorators.registerClass('GXpert.Masters.AcademicYearGrid')
export class AcademicYearGrid extends EntityGrid<AcademicYearRow, any> {
    protected getColumnsKey() { return AcademicYearColumns.columnsKey; }
    protected getDialogType() { return AcademicYearDialog; }
    protected getRowDefinition() { return AcademicYearRow; }
    protected getService() { return AcademicYearService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}