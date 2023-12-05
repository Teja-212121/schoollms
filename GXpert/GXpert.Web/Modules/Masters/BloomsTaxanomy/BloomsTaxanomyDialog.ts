import { BloomsTaxanomyForm, BloomsTaxanomyRow, BloomsTaxanomyService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.BloomsTaxanomyDialog')
export class BloomsTaxanomyDialog extends EntityDialog<BloomsTaxanomyRow, any> {
    protected getFormKey() { return BloomsTaxanomyForm.formKey; }
    protected getRowDefinition() { return BloomsTaxanomyRow; }
    protected getService() { return BloomsTaxanomyService.baseUrl; }

    protected form = new BloomsTaxanomyForm(this.idPrefix);
}