import { LookupEditor, IntegerEditor, StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteStudentForm {
    StudentId: LookupEditor;
    SchoolId: IntegerEditor;
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
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = TextAreaEditor;

            initFormType(InstituteStudentForm, [
                'StudentId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'Division', w2,
                'RollNumber', w2,
                'Description', w3,
                'AcademicYearId', w0
            ]);
        }
    }
}