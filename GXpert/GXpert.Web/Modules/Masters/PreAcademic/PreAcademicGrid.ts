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
}