import { DistrictForm, DistrictRow, DistrictService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.DistrictDialog')
export class DistrictDialog extends EntityDialog<DistrictRow, any> {
    protected getFormKey() { return DistrictForm.formKey; }
    protected getRowDefinition() { return DistrictRow; }
    protected getService() { return DistrictService.baseUrl; }

    protected form = new DistrictForm(this.idPrefix);
}