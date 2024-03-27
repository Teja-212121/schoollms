import { IntegerEditor, LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteClassForm {
    InstituteId: IntegerEditor;
    DepartmentId: IntegerEditor;
    CourseId: LookupEditor;
    ClassId: LookupEditor;
    SemesterId: IntegerEditor;
    Title: StringEditor;
    Division: StringEditor;
    ClassTeacherId: LookupEditor;
    AcademicYearId: LookupEditor;
}

export class InstituteClassForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteClass';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteClassForm.init)  {
            InstituteClassForm.init = true;

            var w0 = IntegerEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;

            initFormType(InstituteClassForm, [
                'InstituteId', w0,
                'DepartmentId', w0,
                'CourseId', w1,
                'ClassId', w1,
                'SemesterId', w0,
                'Title', w2,
                'Division', w2,
                'ClassTeacherId', w1,
                'AcademicYearId', w1
            ]);
        }
    }
}