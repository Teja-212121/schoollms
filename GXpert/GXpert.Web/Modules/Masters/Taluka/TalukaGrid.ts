import { TalukaColumns, TalukaRow, TalukaService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TalukaDialog } from './TalukaDialog';

@Decorators.registerClass('GXpert.Masters.TalukaGrid')
export class TalukaGrid extends EntityGrid<TalukaRow, any> {
    protected getColumnsKey() { return TalukaColumns.columnsKey; }
    protected getDialogType() { return TalukaDialog; }
    protected getRowDefinition() { return TalukaRow; }
    protected getService() { return TalukaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}