import { StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicYearForm {
    Name: StringEditor;
    Description: StringEditor;
    StartDate: DateEditor;
    EndDate: DateEditor;
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

            initFormType(AcademicYearForm, [
                'Name', w0,
                'Description', w0,
                'StartDate', w1,
                'EndDate', w1
            ]);
        }
    }
}