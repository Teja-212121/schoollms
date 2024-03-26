import { StateForm, StateImportForm, StateRow, StateService, TalukaImportForm, TalukaRow, TalukaService } from '@/ServerTypes/Masters';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.TalukaImportDialog')
export class TalukaImportDialog extends EntityDialog<TalukaRow, any> {
    protected getFormKey() { return TalukaImportForm.formKey; }
    protected getRowDefinition() { return TalukaRow; }
    protected getService() { return TalukaService.baseUrl; }

    protected form = new TalukaImportForm(this.idPrefix);


    constructor() {
        super();
        this.form = new TalukaImportForm(this.idPrefix);
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

                    TalukaService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                      
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