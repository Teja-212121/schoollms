import { LookupEditor, StringEditor, TextAreaEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteStudentForm {
    InstituteId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: LookupEditor;
    InstituteDivisionId: LookupEditor;
    StudentId: LookupEditor;
    RollNumber: StringEditor;
    AcademicYearId: LookupEditor;
    Description: TextAreaEditor;
    StartDate: DateEditor;
    EndDate: DateEditor;
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
            var w3 = DateEditor;

            initFormType(InstituteStudentForm, [
                'InstituteId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'InstituteDivisionId', w0,
                'StudentId', w0,
                'RollNumber', w1,
                'AcademicYearId', w0,
                'Description', w2,
                'StartDate', w3,
                'EndDate', w3
            ]);
        }
    }
}