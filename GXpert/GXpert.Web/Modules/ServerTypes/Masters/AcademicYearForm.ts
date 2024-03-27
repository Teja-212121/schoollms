import { StringEditor, DateEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicYearForm {
    Name: StringEditor;
    StartDate: DateEditor;
    EndDate: DateEditor;
    Description: TextAreaEditor;
}

export class AcademicYearForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicYear';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicYearForm.init)  {
            AcademicYearForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = TextAreaEditor;

            initFormType(AcademicYearForm, [
                'Name', w0,
                'StartDate', w1,
                'EndDate', w1,
                'Description', w2
            ]);
        }
    }
}