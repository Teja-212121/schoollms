import { DistrictColumns, DistrictRow, DistrictService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DistrictDialog } from './DistrictDialog';

@Decorators.registerClass('GXpert.Masters.DistrictGrid')
export class DistrictGrid extends EntityGrid<DistrictRow, any> {
    protected getColumnsKey() { return DistrictColumns.columnsKey; }
    protected getDialogType() { return DistrictDialog; }
    protected getRowDefinition() { return DistrictRow; }
    protected getService() { return DistrictService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}