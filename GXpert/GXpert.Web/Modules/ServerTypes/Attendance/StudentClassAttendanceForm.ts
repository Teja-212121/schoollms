import { ServiceLookupEditor, LookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EAttendanceStatus } from "../Web/Enums.EAttendanceStatus";

export interface StudentClassAttendanceForm {
    InstituteTimeTableId: ServiceLookupEditor;
    StudentId: LookupEditor;
    AttendanceStatus: EnumEditor;
}

export class StudentClassAttendanceForm extends PrefixedContext {
    static readonly formKey = 'Attendance.StudentClassAttendance';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentClassAttendanceForm.init)  {
            StudentClassAttendanceForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = EnumEditor;

            initFormType(StudentClassAttendanceForm, [
                'InstituteTimeTableId', w0,
                'StudentId', w1,
                'AttendanceStatus', w2
            ]);
        }
    }
}

[EAttendanceStatus]; // referenced types