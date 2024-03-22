import { PrincipalColumns, PrincipalRow, PrincipalService } from '@/ServerTypes/Users';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PrincipalDialog } from './PrincipalDialog';

@Decorators.registerClass('GXpert.Users.PrincipalGrid')
export class PrincipalGrid extends EntityGrid<PrincipalRow, any> {
    protected getColumnsKey() { return PrincipalColumns.columnsKey; }
    protected getDialogType() { return PrincipalDialog; }
    protected getRowDefinition() { return PrincipalRow; }
    protected getService() { return PrincipalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}