import { InstituteClassColumns, InstituteClassRow, InstituteClassService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteClassDialog } from './InstituteClassDialog';

@Decorators.registerClass('GXpert.Institute.InstituteClassGrid')
export class InstituteClassGrid extends EntityGrid<InstituteClassRow, any> {
    protected getColumnsKey() { return InstituteClassColumns.columnsKey; }
    protected getDialogType() { return InstituteClassDialog; }
    protected getRowDefinition() { return InstituteClassRow; }
    protected getService() { return InstituteClassService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}