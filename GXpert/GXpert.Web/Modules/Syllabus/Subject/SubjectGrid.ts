import { SubjectColumns, SubjectExcelImportForm, SubjectRow, SubjectService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid, postToService, resolveUrl } from '@serenity-is/corelib';
import { SubjectDialog } from './SubjectDialog';
import { SubjectExcelImportDialog } from './SubjectExcelImportDialog';
import { ExcelExportHelper } from '@serenity-is/extensions';

@Decorators.registerClass('GXpert.Syllabus.SubjectGrid')
export class SubjectGrid extends EntityGrid<SubjectRow, any> {
    protected getColumnsKey() { return SubjectColumns.columnsKey; }
    protected getDialogType() { return SubjectDialog; }
    protected getRowDefinition() { return SubjectRow; }
    protected getService() { return SubjectService.baseUrl; }

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
                var dialog = new SubjectExcelImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            }
        });

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit(),
            service: SubjectService.baseUrl + '/ListExcel',
            separator: true,
            hint: "this is the hint",
            title: "Export to excel"
        }));

        buttons.push({
            title: 'Download Subject Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                debugger;

                var url = "~/Syllabus/SubjectDownloadImportSample";

                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        });
        return buttons;
    }
}