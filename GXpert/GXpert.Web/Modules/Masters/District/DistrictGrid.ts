import { DistrictColumns, DistrictRow, DistrictService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { DistrictDialog } from './DistrictDialog';
import { DistrictImportDialog } from './DistrictImportDialog';

@Decorators.registerClass('GXpert.Masters.DistrictGrid')
export class DistrictGrid extends EntityGrid<DistrictRow, any> {
    rowSelection: any;
    protected getColumnsKey() { return DistrictColumns.columnsKey; }
    protected getDialogType() { return DistrictDialog; }
    protected getRowDefinition() { return DistrictRow; }
    protected getService() { return DistrictService.baseUrl; }

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
                var dialog = new DistrictImportDialog();
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
                var url = "~/Masters/District/DistrictSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}