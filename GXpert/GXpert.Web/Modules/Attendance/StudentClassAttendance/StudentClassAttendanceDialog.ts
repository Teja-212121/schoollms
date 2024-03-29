import { StudentClassAttendanceForm, StudentClassAttendanceRow, StudentClassAttendanceService } from '@/ServerTypes/Attendance';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Attendance.StudentClassAttendanceDialog')
export class StudentClassAttendanceDialog extends EntityDialog<StudentClassAttendanceRow, any> {
    protected getFormKey() { return StudentClassAttendanceForm.formKey; }
    protected getRowDefinition() { return StudentClassAttendanceRow; }
    protected getService() { return StudentClassAttendanceService.baseUrl; }

    protected form = new StudentClassAttendanceForm(this.idPrefix);
}