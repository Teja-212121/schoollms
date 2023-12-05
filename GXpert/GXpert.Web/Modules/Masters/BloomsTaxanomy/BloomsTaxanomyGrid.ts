import { BloomsTaxanomyColumns, BloomsTaxanomyRow, BloomsTaxanomyService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BloomsTaxanomyDialog } from './BloomsTaxanomyDialog';

@Decorators.registerClass('GXpert.Masters.BloomsTaxanomyGrid')
export class BloomsTaxanomyGrid extends EntityGrid<BloomsTaxanomyRow, any> {
    protected getColumnsKey() { return BloomsTaxanomyColumns.columnsKey; }
    protected getDialogType() { return BloomsTaxanomyDialog; }
    protected getRowDefinition() { return BloomsTaxanomyRow; }
    protected getService() { return BloomsTaxanomyService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}