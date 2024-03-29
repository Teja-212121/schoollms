import { StudentClassAttendanceColumns, StudentClassAttendanceExcelImportForm, StudentClassAttendanceRow, StudentClassAttendanceService } from '@/ServerTypes/Attendance';
import { Decorators, EntityGrid, postToService, resolveUrl } from '@serenity-is/corelib';
import { StudentClassAttendanceDialog } from './StudentClassAttendanceDialog';
import { StudentClassAttendanceExcelImportDialog } from './StudentClassAttendanceExcelImportDialog';


@Decorators.registerClass('GXpert.Attendance.StudentClassAttendanceGrid')
export class StudentClassAttendanceGrid extends EntityGrid<StudentClassAttendanceRow, any> {
    protected getColumnsKey() { return StudentClassAttendanceColumns.columnsKey; }
    protected getDialogType() { return StudentClassAttendanceDialog; }
    protected getRowDefinition() { return StudentClassAttendanceRow; }
    protected getService() { return StudentClassAttendanceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    } protected getButtons() {
        var buttons = super.getButtons(); buttons.splice(1, 3);
        buttons.push({
            title: 'Import From Excel', cssClass: 'export-xlsx-button',
            onClick: () => {                // open import dialog, let it handle rest
                var dialog = new StudentClassAttendanceExcelImportDialog(); dialog.element.on('dialogclose', () => {
                    this.refresh(); dialog = null;
                }); dialog.dialogOpen();
            }
        });
        buttons.push({
            title: 'Download Sample',
            cssClass: 'export-xlsx-button', onClick: () => {
                debugger;
                var url = "~/Attendance/StudentClassAttendance/StudentAttendanceImportSample";
                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        }); return buttons;
    }
}