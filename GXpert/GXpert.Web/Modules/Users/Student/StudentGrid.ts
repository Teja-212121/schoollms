import { StudentColumns, StudentRow, StudentService } from '@/ServerTypes/Users';
import { Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { StudentDialog } from './StudentDialog';
import { StudentImportDialog } from './StudentImportDialog';

@Decorators.registerClass('GXpert.Users.StudentGrid')
export class StudentGrid extends EntityGrid<StudentRow, any> {
    rowSelection: any;
    protected getColumnsKey() { return StudentColumns.columnsKey; }
    protected getDialogType() { return StudentDialog; }
    protected getRowDefinition() { return StudentRow; }
    protected getService() { return StudentService.baseUrl; }

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
                var dialog = new StudentImportDialog();
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
                var url = "~/Users/Student/StudentSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}