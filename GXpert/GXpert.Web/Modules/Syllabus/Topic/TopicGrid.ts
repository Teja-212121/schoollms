import { TopicColumns, TopicRow, TopicService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid, postToService, resolveUrl } from '@serenity-is/corelib';
import { TopicDialog } from './TopicDialog';
import { TopicExcelImportDialog } from './TopicExcelImportDialog';
import { ExcelExportHelper } from '@serenity-is/extensions';
@Decorators.registerClass('GXpert.Syllabus.TopicGrid')
export class TopicGrid extends EntityGrid<TopicRow, any> {
    protected getColumnsKey() { return TopicColumns.columnsKey; }
    protected getDialogType() { return TopicDialog; }
    protected getRowDefinition() { return TopicRow; }
    protected getService() { return TopicService.baseUrl; }

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
                var dialog = new TopicExcelImportDialog();
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
            service: TopicService.baseUrl + '/ListExcel',
            separator: true,
            hint: "this is the hint",
            title: "Export to excel"
        }));

        buttons.push({
            title: 'Download Topic Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                debugger;

                var url = "~/Syllabus/TopicDownloadImportSample";

                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        });
        return buttons;
    }
}