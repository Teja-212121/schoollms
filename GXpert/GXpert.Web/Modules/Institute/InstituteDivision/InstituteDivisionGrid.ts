import { InstituteDivisionColumns, InstituteDivisionRow, InstituteDivisionService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteDivisionDialog } from './InstituteDivisionDialog';

@Decorators.registerClass('GXpert.Institute.InstituteDivisionGrid')
export class InstituteDivisionGrid extends EntityGrid<InstituteDivisionRow, any> {
    protected getColumnsKey() { return InstituteDivisionColumns.columnsKey; }
    protected getDialogType() { return InstituteDivisionDialog; }
    protected getRowDefinition() { return InstituteDivisionRow; }
    protected getService() { return InstituteDivisionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}