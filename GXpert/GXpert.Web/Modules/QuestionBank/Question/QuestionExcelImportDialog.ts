import { QuestionExcellmportForm,QuestionForm, QuestionRow, QuestionService } from '@/ServerTypes/QuestionBank';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.QuestionBank.QuestionDialog')
export class QuestionExcelImportDialog extends EntityDialog<QuestionRow, any> {
    protected getFormKey() { return QuestionExcellmportForm.formKey; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    protected form = new QuestionExcellmportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new QuestionExcellmportForm(this.idPrefix);
    }
    protected getDialogTitle(): string {
        return "Excel Import";
    }

    protected getDialogButtons(): DialogButton[] {
        return [
            {
                text: 'Import',
                click: () => {
                    if (!this.validateBeforeSave())
                        return;

                    if (this.form.FileName.value == null ||
                        isEmptyOrNull(this.form.FileName.value.Filename)) {
                        notifyError("Please select a file!");
                        return;
                    }

                    QuestionService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                        // TenantId: this.form.TenantId.value,
                        // GroupId: Number(this.form.GroupId.value)

                    }, response => {
                        notifyInfo(
                            'Inserted: ' + (response.Inserted || 0));

                        if (response.ErrorList != null && response.ErrorList.length > 0) {
                            notifyError(response.ErrorList.join(',\r\n '));
                        }
                        this.dialogClose();
                    });
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }
}