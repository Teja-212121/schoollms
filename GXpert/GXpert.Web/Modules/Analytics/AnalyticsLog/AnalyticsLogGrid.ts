import { AnalyticsLogColumns, AnalyticsLogRow, AnalyticsLogService } from '@/ServerTypes/Analytics';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AnalyticsLogDialog } from './AnalyticsLogDialog';

@Decorators.registerClass('GXpert.Analytics.AnalyticsLogGrid')
export class AnalyticsLogGrid extends EntityGrid<AnalyticsLogRow, any> {
    protected getColumnsKey() { return AnalyticsLogColumns.columnsKey; }
    protected getDialogType() { return AnalyticsLogDialog; }
    protected getRowDefinition() { return AnalyticsLogRow; }
    protected getService() { return AnalyticsLogService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}