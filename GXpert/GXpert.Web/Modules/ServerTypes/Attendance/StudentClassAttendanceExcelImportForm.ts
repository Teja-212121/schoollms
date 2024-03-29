import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StudentClassAttendanceExcelImportForm {
    FileName: ImageUploadEditor;
}

export class StudentClassAttendanceExcelImportForm extends PrefixedContext {
    static readonly formKey = 'Attendance.StudentClassAttendanceExcelImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentClassAttendanceExcelImportForm.init)  {
            StudentClassAttendanceExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(StudentClassAttendanceExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}