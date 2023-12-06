import { LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SchoolClassForm {
    ClassId: LookupEditor;
    Division: StringEditor;
    MediumId: LookupEditor;
    ClassTeacherId: LookupEditor;
    Title: StringEditor;
    AcademicYearId: LookupEditor;
}

export class SchoolClassForm extends PrefixedContext {
    static readonly formKey = 'Schools.SchoolClass';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SchoolClassForm.init)  {
            SchoolClassForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;

            initFormType(SchoolClassForm, [
                'ClassId', w0,
                'Division', w1,
                'MediumId', w0,
                'ClassTeacherId', w0,
                'Title', w1,
                'AcademicYearId', w0
            ]);
        }
    }
}