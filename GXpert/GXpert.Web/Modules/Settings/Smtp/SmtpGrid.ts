import { SmtpColumns, SmtpRow, SmtpService } from '@/ServerTypes/Settings';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SmtpDialog } from './SmtpDialog';

@Decorators.registerClass('GXpert.Settings.SmtpGrid')
export class SmtpGrid extends EntityGrid<SmtpRow, any> {
    protected getColumnsKey() { return SmtpColumns.columnsKey; }
    protected getDialogType() { return SmtpDialog; }
    protected getRowDefinition() { return SmtpRow; }
    protected getService() { return SmtpService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}