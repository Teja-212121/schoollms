import { InstituteDivisionForm, InstituteDivisionRow, InstituteDivisionService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteDivisionDialog')
export class InstituteDivisionDialog extends EntityDialog<InstituteDivisionRow, any> {
    protected getFormKey() { return InstituteDivisionForm.formKey; }
    protected getRowDefinition() { return InstituteDivisionRow; }
    protected getService() { return InstituteDivisionService.baseUrl; }

    protected form = new InstituteDivisionForm(this.idPrefix);
}