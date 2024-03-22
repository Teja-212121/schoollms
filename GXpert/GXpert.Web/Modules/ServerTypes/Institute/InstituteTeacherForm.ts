import { LookupEditor, IntegerEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTeacherForm {
    TeacherId: LookupEditor;
    SchoolId: IntegerEditor;
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
            var w1 = IntegerEditor;
            var w2 = TextAreaEditor;

            initFormType(InstituteTeacherForm, [
                'TeacherId', w0,
                'SchoolId', w1,
                'ClassId', w0,
                'SubjectId', w0,
                'Description', w2,
                'AcademicYearId', w0
            ]);
        }
    }
}