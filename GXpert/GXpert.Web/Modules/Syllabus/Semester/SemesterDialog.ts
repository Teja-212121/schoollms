import { SemesterForm, SemesterRow, SemesterService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.SemesterDialog')
export class SemesterDialog extends EntityDialog<SemesterRow, any> {
    protected getFormKey() { return SemesterForm.formKey; }
    protected getRowDefinition() { return SemesterRow; }
    protected getService() { return SemesterService.baseUrl; }

    protected form = new SemesterForm(this.idPrefix);
}