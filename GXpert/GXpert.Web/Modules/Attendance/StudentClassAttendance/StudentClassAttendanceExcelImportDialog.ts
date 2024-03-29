import { StudentClassAttendanceExcelImportForm, StudentClassAttendanceForm, StudentClassAttendanceRow, StudentClassAttendanceService } from '@/ServerTypes/Attendance';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.StudentClassAttendanceDialog')
export class StudentClassAttendanceExcelImportDialog extends EntityDialog<StudentClassAttendanceRow, any> {
    protected getFormKey() { return StudentClassAttendanceExcelImportForm.formKey; }
    protected getRowDefinition() { return StudentClassAttendanceRow; }
    protected getService() { return StudentClassAttendanceService.baseUrl; }

    protected form = new StudentClassAttendanceExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new StudentClassAttendanceExcelImportForm(this.idPrefix);
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

                    StudentClassAttendanceService.ExcelImport({
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
