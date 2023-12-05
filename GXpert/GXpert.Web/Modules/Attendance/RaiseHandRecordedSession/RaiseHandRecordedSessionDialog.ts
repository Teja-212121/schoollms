import { RaiseHandRecordedSessionForm, RaiseHandRecordedSessionRow, RaiseHandRecordedSessionService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.RaiseHandRecordedSessionDialog')
export class RaiseHandRecordedSessionDialog extends EntityDialog<RaiseHandRecordedSessionRow, any> {
    protected getFormKey() { return RaiseHandRecordedSessionForm.formKey; }
    protected getRowDefinition() { return RaiseHandRecordedSessionRow; }
    protected getService() { return RaiseHandRecordedSessionService.baseUrl; }

    protected form = new RaiseHandRecordedSessionForm(this.idPrefix);
}