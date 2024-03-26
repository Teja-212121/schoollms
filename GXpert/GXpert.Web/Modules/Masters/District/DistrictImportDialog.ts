import { DistrictImportForm, DistrictRow, DistrictService, StateForm, StateImportForm, StateRow, StateService } from '@/ServerTypes/Masters';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.DistrictImportDialog')
export class DistrictImportDialog extends EntityDialog<DistrictRow, any> {
    protected getFormKey() { return DistrictImportForm.formKey; }
    protected getRowDefinition() { return DistrictRow; }
    protected getService() { return DistrictService.baseUrl; }

    protected form = new DistrictImportForm(this.idPrefix);


    constructor() {
        super();
        this.form = new DistrictImportForm(this.idPrefix);
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

                    DistrictService.ExcelImport({
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