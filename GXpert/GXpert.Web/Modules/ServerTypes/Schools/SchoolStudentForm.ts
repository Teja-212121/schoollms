import { LookupEditor, ServiceLookupEditor, StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolStudentForm {
    StudentId: LookupEditor;
    SchoolId: ServiceLookupEditor;
    ClassId: LookupEditor;
    Division: StringEditor;
    RollNumber: StringEditor;
    Description: TextAreaEditor;
    AcademicYearId: LookupEditor;
}

export class SchoolStudentForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolStudent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolStudentForm.init)  {
            SchoolStudentForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = TextAreaEditor;

            initFormType(SchoolStudentForm, [
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