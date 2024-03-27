import { LookupEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTeacherForm {
    TeacherId: LookupEditor;
    InstituteId: LookupEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    Description: TextAreaEditor;
    AcademicYearId: LookupEditor;
}

export class InstituteTeacherForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTeacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTeacherForm.init)  {
            InstituteTeacherForm.init = true;

            var w0 = LookupEditor;
            var w1 = TextAreaEditor;

            initFormType(InstituteTeacherForm, [
                'TeacherId', w0,
                'InstituteId', w0,
                'ClassId', w0,
                'SubjectId', w0,
                'Description', w1,
                'AcademicYearId', w0
            ]);
        }
    }
}