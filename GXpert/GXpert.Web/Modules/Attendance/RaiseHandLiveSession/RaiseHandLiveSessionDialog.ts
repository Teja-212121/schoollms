import { RaiseHandLiveSessionForm, RaiseHandLiveSessionRow, RaiseHandLiveSessionService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.RaiseHandLiveSessionDialog')
export class RaiseHandLiveSessionDialog extends EntityDialog<RaiseHandLiveSessionRow, any> {
    protected getFormKey() { return RaiseHandLiveSessionForm.formKey; }
    protected getRowDefinition() { return RaiseHandLiveSessionRow; }
    protected getService() { return RaiseHandLiveSessionService.baseUrl; }

    protected form = new RaiseHandLiveSessionForm(this.idPrefix);
}