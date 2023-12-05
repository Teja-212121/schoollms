import { LiveSessionForm, LiveSessionRow, LiveSessionService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.LiveSessions.LiveSessionDialog')
export class LiveSessionDialog extends EntityDialog<LiveSessionRow, any> {
    protected getFormKey() { return LiveSessionForm.formKey; }
    protected getRowDefinition() { return LiveSessionRow; }
    protected getService() { return LiveSessionService.baseUrl; }

    protected form = new LiveSessionForm(this.idPrefix);
}