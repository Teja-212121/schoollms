import { LookupEditor, IntegerEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTeacherForm {
    InstituteId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: IntegerEditor;
    SubjectId: LookupEditor;
    TeacherId: LookupEditor;
    InstituteDivisionId: LookupEditor;
    AcademicYearId: LookupEditor;
    Description: TextAreaEditor;
}

export class InstituteTeacherForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTeacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTeacherForm.init)  {
            InstituteTeacherForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = TextAreaEditor;

            initFormType(InstituteTeacherForm, [
                'InstituteId', w0,
                'ClassId', w0,
                'SemesterId', w1,
                'SubjectId', w0,
                'TeacherId', w0,
                'InstituteDivisionId', w0,
                'AcademicYearId', w0,
                'Description', w2
            ]);
        }
    }
}