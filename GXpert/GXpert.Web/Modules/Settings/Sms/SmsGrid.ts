import { SmsColumns, SmsRow, SmsService } from '@/ServerTypes/Settings';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SmsDialog } from './SmsDialog';

@Decorators.registerClass('GXpert.Settings.SmsGrid')
export class SmsGrid extends EntityGrid<SmsRow, any> {
    protected getColumnsKey() { return SmsColumns.columnsKey; }
    protected getDialogType() { return SmsDialog; }
    protected getRowDefinition() { return SmsRow; }
    protected getService() { return SmsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}