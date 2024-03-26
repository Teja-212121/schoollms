import { StateColumns, StateRow, StateService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { StateDialog } from './StateDialog';
import { StateImportDialog } from './StateImportDialog';

@Decorators.registerClass('GXpert.Masters.StateGrid')
export class StateGrid extends EntityGrid<StateRow, any> {
    rowSelection: any;
    protected getColumnsKey() { return StateColumns.columnsKey; }
    protected getDialogType() { return StateDialog; }
    protected getRowDefinition() { return StateRow; }
    protected getService() { return StateService.baseUrl; }

    

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
                var dialog = new StateImportDialog();
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
                var url = "~/Masters/State/StateSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}