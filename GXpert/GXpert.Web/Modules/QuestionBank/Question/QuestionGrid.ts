import { QuestionColumns, QuestionRow, QuestionService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityGrid, postToService, resolveUrl } from '@serenity-is/corelib';
import { QuestionDialog } from './QuestionDialog';
import { QuestionExcelImportDialog } from './QuestionExcelImportDialog';

@Decorators.registerClass('GXpert.QuestionBank.QuestionGrid')
export class QuestionGrid extends EntityGrid<QuestionRow, any> {
    protected getColumnsKey() { return QuestionColumns.columnsKey; }
    protected getDialogType() { return QuestionDialog; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    
    constructor(container: JQuery) {
        super(container);
    } protected getButtons() {
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
            title: 'Download Sample',
            cssClass: 'export-xlsx-button', onClick: () => {
                debugger;
                var url = "~/QuestionBank/Question/QuestionDownloadSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        }); return buttons;
    }
}

