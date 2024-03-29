import { AcademicSubjectPerformanceForm, AcademicSubjectPerformanceImportForm, AcademicSubjectPerformanceRow, AcademicSubjectPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, DialogButton, EditorUtils, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.AcademicSubjectPerformanceImportDialog')
export class AcademicSubjectPerformanceImportDialog extends EntityDialog<AcademicSubjectPerformanceRow, any> {
    protected getFormKey() { return AcademicSubjectPerformanceImportForm.formKey; }
    protected getRowDefinition() { return AcademicSubjectPerformanceRow; }
    protected getService() { return AcademicSubjectPerformanceService.baseUrl; }

    protected form = new AcademicSubjectPerformanceImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new AcademicSubjectPerformanceImportForm(this.idPrefix);
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

                    AcademicSubjectPerformanceService.ExcelImport({
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