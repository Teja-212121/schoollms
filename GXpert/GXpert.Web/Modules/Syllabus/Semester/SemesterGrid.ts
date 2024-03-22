import { SemesterColumns, SemesterRow, SemesterService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SemesterDialog } from './SemesterDialog';

@Decorators.registerClass('GXpert.Syllabus.SemesterGrid')
export class SemesterGrid extends EntityGrid<SemesterRow, any> {
    protected getColumnsKey() { return SemesterColumns.columnsKey; }
    protected getDialogType() { return SemesterDialog; }
    protected getRowDefinition() { return SemesterRow; }
    protected getService() { return SemesterService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}