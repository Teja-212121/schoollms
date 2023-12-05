import { PollForm, PollRow, PollService } from '@/ServerTypes/LiveSessions';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.LiveSessions.PollDialog')
export class PollDialog extends EntityDialog<PollRow, any> {
    protected getFormKey() { return PollForm.formKey; }
    protected getRowDefinition() { return PollRow; }
    protected getService() { return PollService.baseUrl; }

    protected form = new PollForm(this.idPrefix);
}