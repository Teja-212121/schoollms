import { LookupEditor, StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteClassForm {
    ClassId: LookupEditor;
    Division: StringEditor;
    MediumId: LookupEditor;
    ClassTeacherId: LookupEditor;
    Title: StringEditor;
    AcademicYearId: LookupEditor;
    InstituteId: IntegerEditor;
    DepartmentId: IntegerEditor;
    CourseId: IntegerEditor;
}

export class InstituteClassForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteClass';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteClassForm.init)  {
            InstituteClassForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;

            initFormType(InstituteClassForm, [
                'ClassId', w0,
                'Division', w1,
                'MediumId', w0,
                'ClassTeacherId', w0,
                'Title', w1,
                'AcademicYearId', w0,
                'InstituteId', w2,
                'DepartmentId', w2,
                'CourseId', w2
            ]);
        }
    }
}