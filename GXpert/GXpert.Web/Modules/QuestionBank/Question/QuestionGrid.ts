import { QuestionColumns, QuestionRow, QuestionService } from '@/ServerTypes/QuestionBank';
import { Authorization, Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { QuestionDialog } from './QuestionDialog';
import { QuestionExcelImportDialog } from './QuestionExcelImportDialog';
import { ExamQuestionForQuestionDialog } from '../../Exams/ExamQuestion/ExamQuestionForQuestionDialog';

@Decorators.registerClass('GXpert.QuestionBank.QuestionGrid')
export class QuestionGrid extends EntityGrid<QuestionRow, any> {
    protected getColumnsKey() { return QuestionColumns.columnsKey; }
    protected getDialogType() { return QuestionDialog; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;
    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        if (!Authorization.hasPermission("Administration:Security")) {
            columns = columns.filter(f => f.field != QuestionRow.Fields.Id);
        }
        return columns;
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons(); buttons.splice(1, 3);
        buttons.push({
            title: 'Import From Excel', cssClass: 'export-xlsx-button',
            onClick: () => {                // open import dialog, let it handle rest
                var dialog = new QuestionExcelImportDialog(); dialog.element.on('dialogclose', () => {
                    this.refresh(); dialog = null;
                }); dialog.dialogOpen();
            }
        });
        buttons.push({
            title: 'Assign to Exam',
            cssClass: 'add-button',
            //icon: 'fa-plus',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    alert("Please select atleast one Exam!");
                    return;
                }
                new ExamQuestionForQuestionDialog(this, true, SelectedKeys).loadNewAndOpenDialog();
            },
            separator: true
        });
        buttons.push({
            title: 'Download Sample',
            cssClass: 'export-xlsx-button', onClick: () => {
                debugger;
                var url = "~/QuestionBank/Question/QuestionDownloadSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        });

        return buttons;
    }
}

