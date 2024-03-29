import { AcademicPerformanceForm, AcademicPerformanceImportForm, AcademicPerformanceRow, AcademicPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, DialogButton, EditorUtils, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.AcademicPerformanceImportDialog')
export class AcademicPerformanceImportDialog extends EntityDialog<AcademicPerformanceRow, any> {
    protected getFormKey() { return AcademicPerformanceImportForm.formKey; }
    protected getRowDefinition() { return AcademicPerformanceRow; }
    protected getService() { return AcademicPerformanceService.baseUrl; }

    protected form = new AcademicPerformanceImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new AcademicPerformanceImportForm(this.idPrefix);
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

                    AcademicPerformanceService.ExcelImport({
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