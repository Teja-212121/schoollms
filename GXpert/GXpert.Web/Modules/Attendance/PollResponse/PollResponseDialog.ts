import { PollResponseForm, PollResponseRow, PollResponseService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.PollResponseDialog')
export class PollResponseDialog extends EntityDialog<PollResponseRow, any> {
    protected getFormKey() { return PollResponseForm.formKey; }
    protected getRowDefinition() { return PollResponseRow; }
    protected getService() { return PollResponseService.baseUrl; }

    protected form = new PollResponseForm(this.idPrefix);
}