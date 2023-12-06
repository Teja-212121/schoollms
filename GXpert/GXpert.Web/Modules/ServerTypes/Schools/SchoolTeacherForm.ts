import { LookupEditor, ServiceLookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolTeacherForm {
    TeacherId: LookupEditor;
    SchoolId: ServiceLookupEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
    Description: StringEditor;
    AcademicYearId: LookupEditor;
}

export class SchoolTeacherForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolTeacher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolTeacherForm.init)  {
            SchoolTeacherForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;

            initFormType(SchoolTeacherForm, [
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