import { DepartmentForm, DepartmentRow, DepartmentService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.DepartmentDialog')
export class DepartmentDialog extends EntityDialog<DepartmentRow, any> {
    protected getFormKey() { return DepartmentForm.formKey; }
    protected getRowDefinition() { return DepartmentRow; }
    protected getService() { return DepartmentService.baseUrl; }

    protected form = new DepartmentForm(this.idPrefix);
}