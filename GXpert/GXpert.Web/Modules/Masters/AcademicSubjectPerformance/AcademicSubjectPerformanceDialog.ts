import { AcademicSubjectPerformanceForm, AcademicSubjectPerformanceRow, AcademicSubjectPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.AcademicSubjectPerformanceDialog')
export class AcademicSubjectPerformanceDialog extends EntityDialog<AcademicSubjectPerformanceRow, any> {
    protected getFormKey() { return AcademicSubjectPerformanceForm.formKey; }
    protected getRowDefinition() { return AcademicSubjectPerformanceRow; }
    protected getService() { return AcademicSubjectPerformanceService.baseUrl; }

    protected form = new AcademicSubjectPerformanceForm(this.idPrefix);
    updateInterface() {
        super.updateInterface();
        EditorUtils.setReadOnly(this.form.StudentId, true);
    }
}