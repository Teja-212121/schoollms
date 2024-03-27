import { InstituteTimeTableColumns, InstituteTimeTableRow, InstituteTimeTableService } from '@/ServerTypes/Institute';
import { Decorators, EntityGrid, postToService, resolveUrl } from '@serenity-is/corelib';
import { InstituteTimeTableDialog } from './InstituteTimeTableDialog';
import { InstituteTimeTableExcelImportDialog } from './InstituteTimeTableExcelImportDialog ';



@Decorators.registerClass('GXpert.Institute.InstituteTimeTableGrid')
export class InstituteTimeTableGrid extends EntityGrid<InstituteTimeTableRow, any> {
    protected getColumnsKey() { return InstituteTimeTableColumns.columnsKey; }
    protected getDialogType() { return InstituteTimeTableDialog; }
    protected getRowDefinition() { return InstituteTimeTableRow; }
    protected getService() { return InstituteTimeTableService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new InstituteTimeTableExcelImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            }
        });
        buttons.push({
            title: 'Download InstituteTimeTable Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                debugger;

                var url = "~/Institute/InstituteTimeTable/InstituteTimeTableDownloadSample";

                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        });
        return buttons;
    }
}
