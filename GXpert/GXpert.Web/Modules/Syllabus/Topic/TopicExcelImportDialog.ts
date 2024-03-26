import { TopicExcelImportForm, TopicForm, TopicRow, TopicService } from '@/ServerTypes/Syllabus';
import { Decorators, DialogButton, EntityDialog, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.TopicExcelImportDialog')
export class TopicExcelImportDialog extends EntityDialog<TopicRow, any> {
    protected getFormKey() { return TopicExcelImportForm.formKey; }
    protected getRowDefinition() { return TopicRow; }
    protected getService() { return TopicService.baseUrl; }

    protected form = new TopicExcelImportForm(this.idPrefix);

    constructor() {
        super();
        this.form = new TopicExcelImportForm(this.idPrefix);
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

                    TopicService.ExcelImport({
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