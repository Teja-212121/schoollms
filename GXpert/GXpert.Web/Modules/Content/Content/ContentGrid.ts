import { ContentColumns, ContentRow, ContentService } from '@/ServerTypes/Content';
import { Authorization, Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ContentDialog } from './ContentDialog';
import { ContentAssignToPlayListcontentDialog } from '../../Playlist/PlayListcontent/ContentAssignToPlayListcontentDialog';

@Decorators.registerClass('GXpert.Content.ContentGrid')
export class ContentGrid extends EntityGrid<ContentRow, any> {
    rowSelection: GridRowSelectionMixin;
    protected getColumnsKey() { return ContentColumns.columnsKey; }
    protected getDialogType() { return ContentDialog; }
    protected getRowDefinition() { return ContentRow; }
    protected getService() { return ContentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        //if (!Authorization.hasPermission("Administration:Security")) {
        //    columns = columns.filter(f => f.field != ContentMediaRow.Fields.TenantId);
        //}
        return columns;
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }
    protected getButtons() {
        var buttons = super.getButtons();

        buttons.push({
            title: 'Assign to PlayList',
            cssClass: 'add-button',
            icon: 'fa-plus',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    alert("Please select atleast one Playlist!");
                    return;
                }
                new ContentAssignToPlayListcontentDialog(this, true, SelectedKeys).loadNewAndOpenDialog();
            },

            separator: true
        });

       

        return buttons;
    }
}