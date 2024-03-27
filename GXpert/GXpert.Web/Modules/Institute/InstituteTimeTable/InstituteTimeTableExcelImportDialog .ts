import { InstituteTimeTableExcelImportForm, InstituteTimeTableForm, InstituteTimeTableRow, InstituteTimeTableService } from '@/ServerTypes/Institute';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Institute.InstituteTimeTableDialog')
export class InstituteTimeTableExcelImportDialog extends EntityDialog<InstituteTimeTableRow, any> {
    FileName: any;
    protected getFormKey() { return InstituteTimeTableForm.formKey; }
    protected getRowDefinition() { return InstituteTimeTableRow; }
    protected getService() { return InstituteTimeTableService.baseUrl; }

    protected form = new InstituteTimeTableExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new InstituteTimeTableExcelImportForm(this.idPrefix);
    }
    protected getDialogTitle(): string {
        return "Excel Import";
    }

    protected getDialogButtons(): DialogButton[] {
        return [
            {

                text: 'Import',
                click: () => {
                    /*debugger;*/
                    if (!this.validateBeforeSave())
                        return;

                    if (this.form.FileName.value == null ||
                        isEmptyOrNull(this.form.FileName.value.Filename)) {
                        notifyError("Please select a file!");
                        return;
                    }

                    InstituteTimeTableService.ExcelImport({
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
   