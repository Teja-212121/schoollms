import { AcademicPerformanceColumns, AcademicPerformanceRow, AcademicPerformanceService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid, GridRowSelectionMixin, postToService, resolveUrl } from '@serenity-is/corelib';
import { AcademicPerformanceDialog } from './AcademicPerformanceDialog';
import { AcademicPerformanceImportDialog } from './AcademicPerformanceImportDialog';

@Decorators.registerClass('GXpert.Masters.AcademicPerformanceGrid')
export class AcademicPerformanceGrid extends EntityGrid<AcademicPerformanceRow, any> {
    rowSelection: GridRowSelectionMixin;
    protected getColumnsKey() { return AcademicPerformanceColumns.columnsKey; }
    protected getDialogType() { return AcademicPerformanceDialog; }
    protected getRowDefinition() { return AcademicPerformanceRow; }
    protected getService() { return AcademicPerformanceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected addButtonClick() {
        this.editItem({ StudentId: this.StudentId });
    }

    protected getInitialTitle() {
        return null;
    }

    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.StudentId;
    }

    private _StudentId: string;

    get StudentId() {
        return this._StudentId;
    }

    set StudentId(value: string) {
        if (this._StudentId !== value) {
            this._StudentId = value;
            this.setEquality('StudentId', value);
            this.refresh();
        }
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
                var dialog = new AcademicPerformanceImportDialog();
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
                var url = "~/Masters/AcademicPerformance/AcademicPerformanceSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}