import { ServiceLookupEditor, LookupEditor, StringEditor, IntegerEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SemesterForm {
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
    Title: StringEditor;
    SortOrder: IntegerEditor;
    Description: TextAreaEditor;
}

export class SemesterForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Semester';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SemesterForm.init)  {
            SemesterForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;
            var w3 = IntegerEditor;
            var w4 = TextAreaEditor;

            initFormType(SemesterForm, [
                'CourseId', w0,
                'ClassId', w1,
                'Title', w2,
                'SortOrder', w3,
                'Description', w4
            ]);
        }
    }
}