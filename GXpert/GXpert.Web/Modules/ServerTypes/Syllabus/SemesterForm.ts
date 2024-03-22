import { StringEditor, ServiceLookupEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SemesterForm {
    Title: StringEditor;
    CourseId: ServiceLookupEditor;
    ClassId: LookupEditor;
}

export class SemesterForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Semester';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SemesterForm.init)  {
            SemesterForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;

            initFormType(SemesterForm, [
                'Title', w0,
                'CourseId', w1,
                'ClassId', w2
            ]);
        }
    }
}