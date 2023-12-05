import { MediumForm, MediumRow, MediumService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.MediumDialog')
export class MediumDialog extends EntityDialog<MediumRow, any> {
    protected getFormKey() { return MediumForm.formKey; }
    protected getRowDefinition() { return MediumRow; }
    protected getService() { return MediumService.baseUrl; }

    protected form = new MediumForm(this.idPrefix);
}