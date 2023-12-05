import { NotificationColumns, NotificationRow, NotificationService } from '@/ServerTypes/Settings';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { NotificationDialog } from './NotificationDialog';

@Decorators.registerClass('GXpert.Settings.NotificationGrid')
export class NotificationGrid extends EntityGrid<NotificationRow, any> {
    protected getColumnsKey() { return NotificationColumns.columnsKey; }
    protected getDialogType() { return NotificationDialog; }
    protected getRowDefinition() { return NotificationRow; }
    protected getService() { return NotificationService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}