import { LookupEditor, StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteStudentForm {
    StudentId: LookupEditor;
    InstituteId: LookupEditor;
    ClassId: LookupEditor;
    Division: StringEditor;
    RollNumber: StringEditor;
    Description: TextAreaEditor;
    AcademicYearId: LookupEditor;
}

export class InstituteStudentForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteStudent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteStudentForm.init)  {
            InstituteStudentForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;

            initFormType(InstituteStudentForm, [
                'StudentId', w0,
                'InstituteId', w0,
                'ClassId', w0,
                'Division', w1,
                'RollNumber', w1,
                'Description', w2,
                'AcademicYearId', w0
            ]);
        }
    }
}