import { StateColumns, StateRow, StateService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StateDialog } from './StateDialog';

@Decorators.registerClass('GXpert.Masters.StateGrid')
export class StateGrid extends EntityGrid<StateRow, any> {
    protected getColumnsKey() { return StateColumns.columnsKey; }
    protected getDialogType() { return StateDialog; }
    protected getRowDefinition() { return StateRow; }
    protected getService() { return StateService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}