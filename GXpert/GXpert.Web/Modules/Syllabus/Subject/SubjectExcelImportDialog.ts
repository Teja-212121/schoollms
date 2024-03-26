import {SubjectExcelImportForm, SubjectRow, SubjectService } from '@/ServerTypes/Syllabus';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.SubjectExcelImport')
export class SubjectExcelImportDialog extends EntityDialog<SubjectRow, any> {
    protected getFormKey() { return SubjectExcelImportForm.formKey; }
    protected getRowDefinition() { return SubjectRow; }
    protected getService() { return SubjectService.baseUrl; }

    protected form = new SubjectExcelImportForm(this.idPrefix);

    constructor() {
        super();
        this.form = new SubjectExcelImportForm(this.idPrefix);
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

                    SubjectService.ExcelImport({
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