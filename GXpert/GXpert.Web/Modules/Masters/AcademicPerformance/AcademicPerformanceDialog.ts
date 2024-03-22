import { AcademicPerformanceForm, AcademicPerformanceRow, AcademicPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.AcademicPerformanceDialog')
export class AcademicPerformanceDialog extends EntityDialog<AcademicPerformanceRow, any> {
    protected getFormKey() { return AcademicPerformanceForm.formKey; }
    protected getRowDefinition() { return AcademicPerformanceRow; }
    protected getService() { return AcademicPerformanceService.baseUrl; }

    protected form = new AcademicPerformanceForm(this.idPrefix);
}