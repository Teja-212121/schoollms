import { TalukaForm, TalukaRow, TalukaService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.TalukaDialog')
export class TalukaDialog extends EntityDialog<TalukaRow, any> {
    protected getFormKey() { return TalukaForm.formKey; }
    protected getRowDefinition() { return TalukaRow; }
    protected getService() { return TalukaService.baseUrl; }

    protected form = new TalukaForm(this.idPrefix);
}