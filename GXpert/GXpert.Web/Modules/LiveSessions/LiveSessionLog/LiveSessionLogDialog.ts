import { LiveSessionLogForm, LiveSessionLogRow, LiveSessionLogService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.LiveSessions.LiveSessionLogDialog')
export class LiveSessionLogDialog extends EntityDialog<LiveSessionLogRow, any> {
    protected getFormKey() { return LiveSessionLogForm.formKey; }
    protected getRowDefinition() { return LiveSessionLogRow; }
    protected getService() { return LiveSessionLogService.baseUrl; }

    protected form = new LiveSessionLogForm(this.idPrefix);
}