import { StudentForm, StudentImportForm, StudentRow, StudentService } from '@/ServerTypes/Users';
import { Decorators, DialogButton, EntityDialog, TabsExtensions, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';



@Decorators.registerClass('GXpert.Users.StudentImportDialog')
export class StudentImportDialog extends EntityDialog<StudentRow, any> {
  
    protected getFormKey() { return StudentImportForm.formKey; }
    protected getRowDefinition() { return StudentRow; }
    protected getService() { return StudentService.baseUrl; }

    protected form = new StudentImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new StudentImportForm(this.idPrefix);
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

                    StudentService.ExcelImport({
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