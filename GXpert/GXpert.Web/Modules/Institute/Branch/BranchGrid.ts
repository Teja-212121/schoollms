import { BranchColumns, BranchRow, BranchService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BranchDialog } from './BranchDialog';

@Decorators.registerClass('GXpert.Institute.BranchGrid')
export class BranchGrid extends EntityGrid<BranchRow, any> {
    protected getColumnsKey() { return BranchColumns.columnsKey; }
    protected getDialogType() { return BranchDialog; }
    protected getRowDefinition() { return BranchRow; }
    protected getService() { return BranchService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}