import { StateForm, StateImportForm, StateRow, StateService } from '@/ServerTypes/Masters';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.StateImportDialog')
export class StateImportDialog extends EntityDialog<StateRow, any> {
    protected getFormKey() { return StateImportForm.formKey; }
    protected getRowDefinition() { return StateRow; }
    protected getService() { return StateService.baseUrl; }

    protected form = new StateImportForm(this.idPrefix);


    constructor() {
        super();
        this.form = new StateImportForm(this.idPrefix);
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

                    StateService.ExcelImport({
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