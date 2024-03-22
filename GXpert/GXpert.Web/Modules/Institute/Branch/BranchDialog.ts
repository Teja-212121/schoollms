import { BranchForm, BranchRow, BranchService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.BranchDialog')
export class BranchDialog extends EntityDialog<BranchRow, any> {
    protected getFormKey() { return BranchForm.formKey; }
    protected getRowDefinition() { return BranchRow; }
    protected getService() { return BranchService.baseUrl; }

    protected form = new BranchForm(this.idPrefix);
}