import { CommonDataColumns, CommonDataRow, CommonDataService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CommonDataDialog } from './CommonDataDialog';

@Decorators.registerClass('GXpert.QuestionBank.CommonDataGrid')
export class CommonDataGrid extends EntityGrid<CommonDataRow, any> {
    protected getColumnsKey() { return CommonDataColumns.columnsKey; }
    protected getDialogType() { return CommonDataDialog; }
    protected getRowDefinition() { return CommonDataRow; }
    protected getService() { return CommonDataService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}