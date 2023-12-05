import { AnalyticsLogForm, AnalyticsLogRow, AnalyticsLogService } from '@/ServerTypes/Analytics';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Analytics.AnalyticsLogDialog')
export class AnalyticsLogDialog extends EntityDialog<AnalyticsLogRow, any> {
    protected getFormKey() { return AnalyticsLogForm.formKey; }
    protected getRowDefinition() { return AnalyticsLogRow; }
    protected getService() { return AnalyticsLogService.baseUrl; }

    protected form = new AnalyticsLogForm(this.idPrefix);
}