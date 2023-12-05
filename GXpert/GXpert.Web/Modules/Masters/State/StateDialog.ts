import { StateForm, StateRow, StateService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.StateDialog')
export class StateDialog extends EntityDialog<StateRow, any> {
    protected getFormKey() { return StateForm.formKey; }
    protected getRowDefinition() { return StateRow; }
    protected getService() { return StateService.baseUrl; }

    protected form = new StateForm(this.idPrefix);
}