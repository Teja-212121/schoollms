import { CommonDataForm, CommonDataRow, CommonDataService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.QuestionBank.CommonDataDialog')
export class CommonDataDialog extends EntityDialog<CommonDataRow, any> {
    protected getFormKey() { return CommonDataForm.formKey; }
    protected getRowDefinition() { return CommonDataRow; }
    protected getService() { return CommonDataService.baseUrl; }

    protected form = new CommonDataForm(this.idPrefix);
}