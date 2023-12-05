import { AcademicYearForm, AcademicYearRow, AcademicYearService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.AcademicYearDialog')
export class AcademicYearDialog extends EntityDialog<AcademicYearRow, any> {
    protected getFormKey() { return AcademicYearForm.formKey; }
    protected getRowDefinition() { return AcademicYearRow; }
    protected getService() { return AcademicYearService.baseUrl; }

    protected form = new AcademicYearForm(this.idPrefix);
}