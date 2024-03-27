import { TalukaColumns, TalukaRow, TalukaService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { TalukaDialog } from './TalukaDialog';
import { TalukaImportDialog } from './TalukaImportDialog';

@Decorators.registerClass('GXpert.Masters.TalukaGrid')
export class TalukaGrid extends EntityGrid<TalukaRow, any> {
    rowSelection: any;
    protected getColumnsKey() { return TalukaColumns.columnsKey; }
    protected getDialogType() { return TalukaDialog; }
    protected getRowDefinition() { return TalukaRow; }
    protected getService() { return TalukaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));

        return columns;
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons();


        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                var dialog = new TalukaImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            },
            separator: true
        });

        buttons.push({
            title: 'Download  Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                var url = "~/Masters/Taluka/TalukaSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}